// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Opc.Ua.Encoders {
    using System;
    using System.Xml;
    using System.IO;
    using Newtonsoft.Json;

    public class TypeSerializer : ITypeSerializer {

        public const string MimeTypeUaJson = "application/ua+json";
        public const string MimeTypeUaNonReversibleJson = "application/json";
        public const string MimeTypeUaBinary = "application/ua+binary";
        public const string MimeTypeUaXml = "application/ua+xml";

        public const string MimeTypeUaJsonOld = "application/ua+json+old";

        /// <summary>
        /// Create codec
        /// </summary>
        /// <param name="contentType"></param>
        public TypeSerializer(string contentType, ServiceMessageContext context) {
            MimeType = contentType;
            _context = context;
        }

        /// <inheritdoc/>
        public string MimeType { get; }

        /// <inheritdoc/>
        public T Decode<T>(byte[] input, Func<IDecoder, T> reader) {
            using (var stream = new MemoryStream(input)) {
                IDecoder decoder = null;
                try {
                    decoder = CreateDecoder(MimeType, stream);
                    return reader(decoder);
                }
                finally {
                    if (decoder is IDisposable dispose) {
                        dispose.Dispose();
                    }
                }
            }
        }

        /// <inheritdoc/>
        public byte[] Encode(Action<IEncoder> writer) {
            using (var stream = new MemoryStream()) {
                IEncoder encoder = null;
                try {
                    encoder = CreateEncoder(MimeType, stream);
                    writer(encoder);

                    // Dispose should flush
                    if (encoder is IDisposable dispose) {
                        dispose.Dispose();
                    }
                    return stream.ToArray();
                }
                catch {
                    if (encoder is IDisposable dispose) {
                        dispose.Dispose();
                    }
                    throw;
                }
            }
        }

        /// <summary>
        /// Create decoder
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        private IDecoder CreateDecoder(string contentType, Stream stream) {
            switch (contentType.ToLowerInvariant()) {
                case MimeTypeUaBinary:
                    return new BinaryDecoder(stream, _context);
                case MimeTypeUaXml:
                    return new XmlDecoder(null, XmlReader.Create(stream), _context);
                case MimeTypeUaJsonOld:
                    return new JsonDecoder(null, new JsonTextReader(
                        new StreamReader(stream)), _context);
                case MimeTypeUaJson:
                case MimeTypeUaNonReversibleJson:
                    return new JsonDecoderEx(_context, new JsonTextReader(
                        new StreamReader(stream)));
                default:
                    throw new ArgumentException(nameof(contentType));
            }
        }

        /// <summary>
        /// Create encoder
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        private IEncoder CreateEncoder(string contentType, Stream stream) {
            switch (contentType.ToLowerInvariant()) {
                case MimeTypeUaJson:
                    return new JsonEncoderEx(_context, new StreamWriter(stream));
                case MimeTypeUaJsonOld:
                    return new JsonEncoder(_context, true, new StreamWriter(stream));
                case MimeTypeUaNonReversibleJson:
                    return new JsonEncoderEx(_context, new StreamWriter(stream)) {
                        UseReversibleEncoding = false
                    };
                case MimeTypeUaBinary:
                    return new BinaryEncoder(stream, _context);
                case MimeTypeUaXml:
                    return new XmlEncoder(
                        new XmlQualifiedName("ua", Namespaces.OpcUaXsd),
                        XmlWriter.Create(stream), _context);
                default:
                    throw new ArgumentException(nameof(contentType));
            }
        }

        private readonly ServiceMessageContext _context;
    }
}
