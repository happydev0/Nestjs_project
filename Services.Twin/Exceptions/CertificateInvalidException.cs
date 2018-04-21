﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcTwin.Services.Exceptions {
    using System;
    using System.Security;

    /// <summary>
    /// Thrown when the external resource is busy
    /// </summary>
    public class CertificateInvalidException : SecurityException {

        public CertificateInvalidException(string message) :
            base(message) {
        }

        public CertificateInvalidException(string message, Exception innerException) :
            base(message, innerException) {
        }
    }
}