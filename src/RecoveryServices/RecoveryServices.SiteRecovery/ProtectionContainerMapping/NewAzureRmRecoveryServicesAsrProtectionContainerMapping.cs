﻿// ----------------------------------------------------------------------------------
// 
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.RecoveryServices.SiteRecovery.Properties;
using Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models;

namespace Microsoft.Azure.Commands.RecoveryServices.SiteRecovery
{
    /// <summary>
    ///    Creates an Azure Site Recovery Protection Container mapping by associating the specified replication policy to the specified ASR protection container.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RecoveryServicesAsrProtectionContainerMapping",DefaultParameterSetName = ASRParameterSets.EnterpriseToAzure,SupportsShouldProcess = true)]
    [Alias("New-ASRProtectionContainerMapping")]
    [OutputType(typeof(ASRJob))]
    public class NewAzureRmRecoveryServicesAsrProtectionContainerMapping : SiteRecoveryCmdletBase
    {
        /// <summary>
        ///     Gets or sets the name of the Protection Container mapping.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.EnterpriseToEnterprise,
            Mandatory = true)]
        [Parameter(
            ParameterSetName = ASRParameterSets.EnterpriseToAzure,
            Mandatory = true)]
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the ASR replication policy object for the replication policy to be used in the mapping.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.EnterpriseToEnterprise,
            Mandatory = true,
            ValueFromPipeline = true)]
        [Parameter(
            ParameterSetName = ASRParameterSets.EnterpriseToAzure,
            Mandatory = true,
            ValueFromPipeline = true)]
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public ASRPolicy Policy { get; set; }

        /// <summary>
        ///     Gets or sets the ASR protection container object for the  primary protection container 
        ///     to be used in the mapping.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.EnterpriseToEnterprise,
            Mandatory = true)]
        [Parameter(
            ParameterSetName = ASRParameterSets.EnterpriseToAzure,
            Mandatory = true)]
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public ASRProtectionContainer PrimaryProtectionContainer { get; set; }

        /// <summary>
        ///     Gets or sets the ASR protection container object for the  recovery protection container 
        ///     to be used in the mapping (used if replicating to a recovery location that is not Azure.)
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.EnterpriseToEnterprise,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public ASRProtectionContainer RecoveryProtectionContainer { get; set; }

        /// <summary>
        /// Gets or sets the target key vault ARM Id for VmwareCbt.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string KeyVaultId { get; set; }

        /// <summary>
        /// Gets or sets the target key vault URL for VmwareCbt.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string KeyVaultUri { get; set; }

        /// <summary>
        /// Gets or sets the storage account ARM Id for VmwareCbt.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the secret name of the storage account for VmwareCbt.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string StorageAccountSasSecretName { get; set; }

        /// <summary>
        /// Gets or sets the secret name of the service bus connection string.
        /// </summary>
        [Parameter(
           ParameterSetName = ASRParameterSets.VMwareCbt,
           Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ServiceBusConnectionStringSecretName { get; set; }

        /// <summary>
        /// Gets or sets the target location for VmwareCbt.
        /// </summary>
        [Parameter(
            ParameterSetName = ASRParameterSets.VMwareCbt,
            Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string TargetLocation { get; set; }

        /// <summary>
        ///     ProcessRecord of the command.
        /// </summary>
        public override void ExecuteSiteRecoveryCmdlet()
        {
            base.ExecuteSiteRecoveryCmdlet();

            if (this.ShouldProcess(
                this.Name,
                VerbsCommon.New))
            {
                switch (this.ParameterSetName)
                {
                    case ASRParameterSets.EnterpriseToAzure:
                        this.EnterpriseToAzureAndVMwareToAzureAssociation();
                        break;
                    case ASRParameterSets.EnterpriseToEnterprise:
                        this.A2AE2EAndVMwareToVMwareAssociation();
                        break;
                    case ASRParameterSets.VMwareCbt:
                        this.VMwareV2Association();
                        break;
                }
            }
        }

        /// <summary>
        ///     Helper to configure cloud
        /// </summary>
        private void Associate(
            string targetProtectionContainerId)
        {
            var inputProperties = new CreateProtectionContainerMappingInputProperties
            {
                PolicyId = this.Policy.ID,
                ProviderSpecificInput = new ReplicationProviderSpecificContainerMappingInput(),
                TargetProtectionContainerId = targetProtectionContainerId
            };

            var input = new CreateProtectionContainerMappingInput { Properties = inputProperties };

            var response = this.RecoveryServicesClient.ConfigureProtection(
                Utilities.GetValueFromArmId(
                    this.PrimaryProtectionContainer.ID,
                    ARMResourceTypeConstants.ReplicationFabrics),
                this.PrimaryProtectionContainer.Name,
                this.Name,
                input);

            var jobResponse = this.RecoveryServicesClient.GetAzureSiteRecoveryJobDetails(
                PSRecoveryServicesClient.GetJobIdFromReponseLocation(response.Location));

            this.WriteObject(new ASRJob(jobResponse));
        }

        /// <summary>
        ///    VMwareCbt Helper to configure cloud
        /// </summary>
        private void VMwareV2Associate(
            string targetProtectionContainerId)
        {
            var vmwareCbtContainerMappingInput = new VMwareCbtContainerMappingInput
            {
                KeyVaultId = this.KeyVaultId,
                KeyVaultUri = this.KeyVaultUri,
                StorageAccountId = this.StorageAccountId,
                ServiceBusConnectionStringSecretName = this.ServiceBusConnectionStringSecretName,
                StorageAccountSasSecretName = this.StorageAccountSasSecretName,
                TargetLocation = this.TargetLocation
            };

            var inputProperties = new CreateProtectionContainerMappingInputProperties
            {
                PolicyId = this.Policy.ID,
                ProviderSpecificInput = vmwareCbtContainerMappingInput,
                TargetProtectionContainerId = targetProtectionContainerId
            };

            var input = new CreateProtectionContainerMappingInput { Properties = inputProperties };

            var response = this.RecoveryServicesClient.ConfigureProtection(
                Utilities.GetValueFromArmId(
                    this.PrimaryProtectionContainer.ID,
                    ARMResourceTypeConstants.ReplicationFabrics),
                this.PrimaryProtectionContainer.Name,
                this.Name,
                input);

           var jobResponse = this.RecoveryServicesClient.GetAzureSiteRecoveryJobDetails(
               PSRecoveryServicesClient.GetJobIdFromReponseLocation(response.Location));

            this.WriteObject(new ASRJob(jobResponse));
        }

        /// <summary>
        ///     Associates Azure Policy with enterprise based protection containers
        /// </summary>
        private void EnterpriseToAzureAndVMwareToAzureAssociation()
        {
            if (string.Compare(
                    this.Policy.ReplicationProvider,
                    Constants.HyperVReplicaAzure,
                    StringComparison.OrdinalIgnoreCase) !=
                0 &&
                string.Compare(
                    this.Policy.ReplicationProvider,
                    Constants.InMageAzureV2,
                    StringComparison.OrdinalIgnoreCase) !=
                0)
            {
                throw new InvalidOperationException(
                    string.Format(
                        Resources.IncorrectReplicationProvider,
                        this.Policy.ReplicationProvider));
            }

            this.Associate(Constants.AzureContainer);
        }

        /// <summary>
        ///     Associates Policy with enterprise/vMware/azure based protection containers
        /// </summary>
        private void A2AE2EAndVMwareToVMwareAssociation()
        {
            if ((string.Compare(
                     this.Policy.ReplicationProvider,
                     Constants.HyperVReplica2012,
                     StringComparison.OrdinalIgnoreCase) !=
                 0) &&
                (string.Compare(
                     this.Policy.ReplicationProvider,
                     Constants.HyperVReplica2012R2,
                     StringComparison.OrdinalIgnoreCase) !=
                 0) &&
                 (string.Compare(
                      this.Policy.ReplicationProvider,
                      Constants.InMage,
                      StringComparison.OrdinalIgnoreCase) !=
                 0) &&
                 (string.Compare(
                      this.Policy.ReplicationProvider,
                      Constants.A2A,
                      StringComparison.OrdinalIgnoreCase) !=
                 0))
            {
                throw new InvalidOperationException(
                    string.Format(
                        Resources.IncorrectReplicationProvider,
                        this.Policy.ReplicationProvider));
            }

            this.Associate(this.RecoveryProtectionContainer.ID);
        }

        /// <summary>
        ///     Associates Policy with VMwareV2 protection containers
        /// </summary>
        private void VMwareV2Association()
        {
            if (string.Compare(
                    this.Policy.ReplicationProvider,
                    Constants.VMwareCbt,
                    StringComparison.OrdinalIgnoreCase) !=
                0)
            {
                throw new InvalidOperationException(
                    string.Format(
                        Resources.IncorrectReplicationProvider,
                        this.Policy.ReplicationProvider));
            }

            this.VMwareV2Associate(Constants.AzureContainer);
        }
    }
}
