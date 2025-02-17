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

namespace Microsoft.Azure.Commands.RecoveryServices.SiteRecovery
{
    /// <summary>
    ///     Recovery services convenience client.
    /// </summary>
    public partial class PSRecoveryServicesClient
    {
        /// <summary>
        ///     Starts Creating Recovery Plan.
        /// </summary>
        /// <param name="resourceGroupName">Resource Group Name</param>
        /// <param name="vaultName">Recovery Service Vault Name</param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <param name="input">Create Recovery Plan Input</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation CreateAzureSiteRecoveryRecoveryPlan(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName,
            CreateRecoveryPlanInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginCreateWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Gets Azure Site Recovery Plans.
        /// </summary>
        /// <returns></returns>
        public List<RecoveryPlan> GetAzureSiteRecoveryRecoveryPlan()
        {
            var firstPage = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.ListWithHttpMessagesAsync(
                    null,
                    null, 
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult()
                .Body;
            var pages = Utilities.GetAllFurtherPages(
                this.GetSiteRecoveryClient()
                    .ReplicationRecoveryPlans.ListNextWithHttpMessagesAsync,
                firstPage.NextPageLink,
                this.GetRequestHeaders(true));
            pages.Insert(
                0,
                firstPage);

            return Utilities.IpageToList(pages);
        }

        /// <summary>
        ///     Gets Azure Site Recovery Recovery Plan.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <returns>Job response</returns>
        public RecoveryPlan GetAzureSiteRecoveryRecoveryPlan(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName)
        {
            return this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.GetWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult()
                .Body;
        }

        /// <summary>
        ///     Remove Azure Site Recovery recovery plan.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation RemoveAzureSiteRecoveryRecoveryPlan(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginDeleteWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);	
            return result;
        }

        /// <summary>
        ///     Starts Azure Site Recovery Commit failover.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryCommitFailover(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginFailoverCommitWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Azure Site Recovery cancel failover.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery plan name.</param>
        /// <returns>Job response.</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryCancelFailover(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginFailoverCancelWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Azure Site Recovery Planned failover.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <param name="input">Recovery Plan Planned Failover Input</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryPlannedFailover(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName,
            RecoveryPlanPlannedFailoverInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginPlannedFailoverWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Azure Site Recovery test failover.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <param name="input">Recovery Plan Test Failover Input</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryTestFailover(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName,
            RecoveryPlanTestFailoverInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginTestFailoverWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Azure Site Recovery test failover cleanup.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name.</param>
        /// <param name="input">Recovery Plan Test Failover cleanup input.</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryTestFailoverCleanup(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName,
            RecoveryPlanTestFailoverCleanupInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginTestFailoverCleanupWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Starts Azure Site Recovery Unplanned failover.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <param name="input">Recovery Plan Unplanned Failover Input</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation StartAzureSiteRecoveryUnplannedFailover(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName,
            RecoveryPlanUnplannedFailoverInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginUnplannedFailoverWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Reprotect Recovery Plan
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation UpdateAzureSiteRecoveryProtection(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginReprotectWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }

        /// <summary>
        ///     Update Azure Site Recovery Recovery Plan.
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="vaultName"></param>
        /// <param name="recoveryPlanName">Recovery Plan Name</param>
        /// <param name="input">Update Recovery Plan Input</param>
        /// <returns>Job response</returns>
        public PSSiteRecoveryLongRunningOperation UpdateAzureSiteRecoveryRecoveryPlan(
            string resourceGroupName,
            string vaultName,
            string recoveryPlanName,
            UpdateRecoveryPlanInput input)
        {
            var op = this.GetSiteRecoveryClient()
                .ReplicationRecoveryPlans.BeginUpdateWithHttpMessagesAsync(
                    resourceGroupName,
                    vaultName,
                    recoveryPlanName,
                    input.Properties,
                    this.GetRequestHeaders(true))
                .GetAwaiter()
                .GetResult();

            var result = SiteRecoveryAutoMapperProfile.Mapper.Map<PSSiteRecoveryLongRunningOperation>(op);
            return result;
        }
    }
}
