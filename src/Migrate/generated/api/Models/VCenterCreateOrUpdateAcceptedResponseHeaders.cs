// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    public partial class VCenterCreateOrUpdateAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IVCenterCreateOrUpdateAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IVCenterCreateOrUpdateAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IVCenterCreateOrUpdateAcceptedResponseHeadersInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader) is string __headerAzureAsyncOperationHeader ? __headerAzureAsyncOperationHeader : (string)null;
            }
        }

        /// <summary>
        /// Creates an new <see cref="VCenterCreateOrUpdateAcceptedResponseHeaders" /> instance.
        /// </summary>
        public VCenterCreateOrUpdateAcceptedResponseHeaders()
        {

        }
    }
    public partial interface IVCenterCreateOrUpdateAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }

    }
    internal partial interface IVCenterCreateOrUpdateAcceptedResponseHeadersInternal

    {
        string AzureAsyncOperation { get; set; }

    }
}