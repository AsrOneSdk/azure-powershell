// ----------------------------------------------------------------------------------
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

using System.Collections.Generic;
using AutoMapper;
using Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models;
using Microsoft.Rest.Azure.OData;

namespace Microsoft.Azure.Commands.RecoveryServices.SiteRecovery
{
    /// <summary>
    ///     Recovery services convenience client.
    /// </summary>
    public partial class PSRecoveryServicesClient
    {
        /// <summary>
        ///     Removes Replicated Protected Item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container ID</param>
        /// <param name="replicationProtectedItemName">Virtual Machine ID or Replication group Id</param>
        /// <param name="input">Disable protection input.</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation DisableProtection(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            DisableProtectionInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginDeleteWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Creates Replicated Protected Item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container ID</param>
        /// <param name="replicationProtectedItemName">Virtual Machine ID or Replication group Id</param>
        /// <param name="input">Enable protection input.</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation EnableProtection(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            EnableProtectionInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginCreateWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Retrieves Replicated Protected Item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container Name</param>
        /// <returns>Protection entity list response</returns>
        public List<ReplicationProtectedItem> GetAzureSiteRecoveryReplicationProtectedItem(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName)
        {
            var firstPage = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems
                .ListByReplicationProtectionContainersWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult()
                .Body;

            var pages = Utilities.GetAllFurtherPages(
                this.GetSiteRecoveryClient()
                    .ReplicationProtectedItems
                    .ListByReplicationProtectionContainersNextWithHttpMessagesAsync,
                firstPage.NextPageLink,
                this.GetRequestHeaders(true));

            pages.Insert(0, firstPage);
            return Utilities.IpageToList(pages);
        }

        /// <summary>
        ///     Retrieves Replicated Protected Item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container Name</param>
        /// <param name="replicatedProtectedItemName">Virtual Machine Name</param>
        /// <returns>Replicated Protected Item response</returns>
        public ReplicationProtectedItem GetAzureSiteRecoveryReplicationProtectedItem(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicatedProtectedItemName)
        {
            return this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.GetWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicatedProtectedItemName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult()
                .Body;
        }

        /// <summary>
        /// Add disks to replicated protected item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container ID</param>
        /// <param name="replicationProtectedItemName">Virtual Machine ID or Replication group Id</param>
        /// <param name="input">Add disks input.</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation AddDisks(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            AddDisksInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginAddDisksWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,   
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        /// Remove disks from replication protected item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item Name</param>
        /// <param name="input">Remove disks input.</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation RemoveDisks(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            RemoveDisksInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginRemoveDisksWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Retrieves Protected Items.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <returns>Protection entity list response</returns>
        public List<ReplicationProtectedItem> GetAzureSiteRecoveryReplicationProtectedItemInRP(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName)
        {
            var protectedItemsQueryParameter =
                new ProtectedItemsQueryParameter { RecoveryPlanName = recoveryPlanName };
            var odataQuery =
                new ODataQuery<ProtectedItemsQueryParameter>(
                    protectedItemsQueryParameter.ToQueryString());
            var firstPage = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.ListWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    odataQuery,
                    null,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult()
                .Body;

            var pages = Utilities.GetAllFurtherPages(
                this.GetSiteRecoveryClient()
                    .ReplicationProtectedItems.ListNextWithHttpMessagesAsync,
                firstPage.NextPageLink,
                this.GetRequestHeaders(true));

            pages.Insert(0, firstPage);
            return Utilities.IpageToList(pages);
        }

        /// <summary>
        ///     Purges Replicated Protected Item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container ID</param>
        /// <param name="replicationProtectedItemName">Virtual Machine ID or Replication group Id</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation PurgeProtection(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginPurgeWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Start applying Recovery Point.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name.</param>
        /// <param name="protectionContainerName">Protection Conatiner Name.</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item.</param>
        /// <param name="input">Input for applying recovery point.</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryApplyRecoveryPoint(
            string resourceGroupName,
            string vaultName, 
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            ApplyRecoveryPointInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginApplyRecoveryPointWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Commit Failover
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Conatiner Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryCommitFailover(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginFailoverCommitWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts cancel failover.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric name.</param>
        /// <param name="protectionContainerName">Protection conatiner name.</param>
        /// <param name="replicationProtectedItemName">Replication protected item.</param>
        /// <returns>Job response.</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryCancelFailover(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginFailoverCancelWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Planned Failover
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Itenm</param>
        /// <param name="input">Input for Planned Failover</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryPlannedFailover(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            PlannedFailoverInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginPlannedFailoverWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Re-protects the Azure Site Recovery protection entity.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Conatiner Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item</param>
        /// <param name="input">Input for Reprotect</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryReprotection(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            ReverseReplicationInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginReprotectWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Test Failover
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Conatiner Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item</param>
        /// <param name="input">Input for Test failover</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryTestFailover(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            TestFailoverInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginTestFailoverWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Test Failover Cleanup.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name.</param>
        /// <param name="protectionContainerName">Protection Conatiner Name.</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item.</param>
        /// <param name="input">Input for Test failover cleanup.</param>
        /// <returns>Job Response.</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryTestFailoverCleanup(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            TestFailoverCleanupInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginTestFailoverCleanupWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Unplanned Failover
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Conatiner Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item</param>
        /// <param name="input">Input for Unplanned failover</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryUnplannedFailover(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            UnplannedFailoverInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginUnplannedFailoverWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Resyncs / Repairs Replication.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Conatiner Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryResynchronizeReplication(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginRepairReplicationWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Updates Mobility Service.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Conatiner Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item</param>
        /// <param name="input">Update Mobility Service Request</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation UpdateAzureSiteRecoveryMobilityService(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            UpdateMobilityServiceRequest input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginUpdateMobilityServiceWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

             var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
             return result;
        }

        /// <summary>
        ///     Switch the Azure Site Recovery protection entity replication direction.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Conatiner Name</param>
        /// <param name="input">Input for Switch</param>
        /// <returns>Job Response</returns>
        public PSSiteRecoveryLongRunningOperation StartSwitchProtection(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            SwitchProtectionInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectionContainers.BeginSwitchProtectionWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Update Azure VM Properties
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name</param>
        /// <param name="protectionContainerName">Protection Container Name</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item</param>
        /// <param name="input">Update Replication Protected Item Input</param>
        /// <returns></returns>
        public PSSiteRecoveryLongRunningOperation UpdateVmProperties(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            UpdateReplicationProtectedItemInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginUpdateWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Switch appliance of a replication protected item.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="fabricName">Fabric Name.</param>
        /// <param name="protectionContainerName">Protection Conatiner Name.</param>
        /// <param name="replicationProtectedItemName">Replication Protected Item.</param>
        /// <param name="input">Input for update appliance.</param>
        /// <returns>Job Response.</returns>
        public PSSiteRecoveryLongRunningOperation SwitchAppliance(
            string resourceGroupName,
            string vaultName,
            string fabricName,
            string protectionContainerName,
            string replicationProtectedItemName,
            UpdateApplianceForReplicationProtectedItemInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationProtectedItems.BeginUpdateApplianceWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    fabricName,
                    protectionContainerName,
                    replicationProtectedItemName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }
    }
}
