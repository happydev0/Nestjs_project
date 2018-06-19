﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Http {
    using Microsoft.Azure.IIoT.Http.Exceptions;
    using Microsoft.Azure.IIoT.Exceptions;
    using System;
    using System.Net;

    public static class HttpResponseEx {

        /// <summary>
        /// Validate response
        /// </summary>
        /// <param name="response"></param>
        public static void Validate(this IHttpResponse response) {
            switch (response.StatusCode) {
                case HttpStatusCode.OK:
                case HttpStatusCode.Created:
                case HttpStatusCode.Accepted:
                case HttpStatusCode.NonAuthoritativeInformation:
                case HttpStatusCode.NoContent:
                case HttpStatusCode.ResetContent:
                case HttpStatusCode.PartialContent:
                    break;
                case HttpStatusCode.MethodNotAllowed:
                    throw new InvalidOperationException(response.Content);
                case HttpStatusCode.NotAcceptable:
                case HttpStatusCode.BadRequest:
                    throw new BadRequestException(response.Content);
                case HttpStatusCode.Forbidden:
                case HttpStatusCode.Unauthorized:
                    throw new UnauthorizedAccessException(response.Content);
                case HttpStatusCode.NotFound:
                    throw new ResourceNotFoundException(response.Content);
                case HttpStatusCode.Conflict:
                    throw new ConflictingResourceException(response.Content);
                case HttpStatusCode.RequestTimeout:
                    throw new TimeoutException(response.Content);
                case HttpStatusCode.PreconditionFailed:
                    throw new ResourceOutOfDateException(response.Content);
                case HttpStatusCode.InternalServerError:
                case HttpStatusCode.GatewayTimeout:
                case HttpStatusCode.TemporaryRedirect:
                case (HttpStatusCode)429:
                    // Retried
                    throw new HttpTransientException(response.StatusCode,
                        response.Content);
                default:
                    throw new HttpResponseException(response.StatusCode,
                        response.Content);
            }
        }
    }
}
