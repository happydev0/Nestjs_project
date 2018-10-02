﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------


using Microsoft.AspNetCore.Http;
using Microsoft.Azure.IIoT.OpcUa.Services.Vault.CosmosDB.Models;
using Microsoft.Azure.IIoT.OpcUa.Services.Vault.Models;
using System.Threading.Tasks;

namespace Microsoft.Azure.IIoT.OpcUa.Services.Vault
{
    /// <summary>
    /// An abstract interface to the certificate request database
    /// </summary>
    public interface ICertificateRequest
    {
        Task Initialize();
        Task<ICertificateRequest> OnBehalfOfRequest(HttpRequest request);
        Task<string> StartSigningRequestAsync(
            string applicationId,
            string certificateGroupId,
            string certificateTypeId,
            byte[] certificateRequest,
            string authorityId);
        Task<string> StartNewKeyPairRequestAsync(
            string applicationId,
            string certificateGroupId,
            string certificateTypeId,
            string subjectName,
            string[] domainNames,
            string privateKeyFormat,
            string privateKeyPassword,
            string authorityId);

        Task ApproveAsync(
            string requestId,
            bool isRejected);

        Task AcceptAsync(
            string requestId);

        Task<FinishRequestResultModel> FinishRequestAsync(
            string requestId,
            string applicationId
            );

        Task<ReadRequestResultModel> ReadAsync(
            string requestId);

        Task<ReadRequestResultModel[]> QueryAsync(
            string appId, 
            CertificateRequestState? state);

    }

}
