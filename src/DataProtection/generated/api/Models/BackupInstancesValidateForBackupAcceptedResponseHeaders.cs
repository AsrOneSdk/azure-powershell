// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    public partial class BackupInstancesValidateForBackupAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstancesValidateForBackupAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstancesValidateForBackupAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Creates an new <see cref="BackupInstancesValidateForBackupAcceptedResponseHeaders" /> instance.
        /// </summary>
        public BackupInstancesValidateForBackupAcceptedResponseHeaders()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstancesValidateForBackupAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstancesValidateForBackupAcceptedResponseHeadersInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader1) is string __headerAzureAsyncOperationHeader1 ? __headerAzureAsyncOperationHeader1 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader2))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBackupInstancesValidateForBackupAcceptedResponseHeadersInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader2) is string __headerRetryAfterHeader2 ? int.TryParse( __headerRetryAfterHeader2, out int __headerRetryAfterHeader2Value ) ? __headerRetryAfterHeader2Value : default(int?) : default(int?);
            }
        }
    }
    public partial interface IBackupInstancesValidateForBackupAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }

    }
    internal partial interface IBackupInstancesValidateForBackupAcceptedResponseHeadersInternal

    {
        string AzureAsyncOperation { get; set; }

        string Location { get; set; }

        int? RetryAfter { get; set; }

    }
}