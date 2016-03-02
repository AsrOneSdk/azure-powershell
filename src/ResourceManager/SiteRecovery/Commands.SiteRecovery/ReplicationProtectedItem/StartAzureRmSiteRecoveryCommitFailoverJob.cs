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
using System.Linq;
using System.Diagnostics;
using System.Management.Automation;
using System.Threading;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Commands.SiteRecovery
{
    /// <summary>
    /// Used to initiate a commit operation.
    /// </summary>
    [Cmdlet(VerbsLifecycle.Start, "AzureRmSiteRecoveryCommitFailoverJob", DefaultParameterSetName = ASRParameterSets.ByPEObject)]
    [OutputType(typeof(ASRJob))]
    public class StartAzureRmSiteRecoveryCommitFailoverJob : SiteRecoveryCmdletBase
    {

        /// <summary>
        /// Gets or sets ID of the Protection Container.
        /// </summary>
        public string protectionContainerName;

        /// <summary>
        /// Gets or sets Name of the Fabric.
        /// </summary>
        public string fabricName;

        #region Parameters

        /// <summary>
        /// Gets or sets Recovery Plan object.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.ByRPObject, Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public ASRRecoveryPlan RecoveryPlan { get; set; }

        /// <summary>
        /// Gets or sets Replication Protected Item.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.ByPEObject, Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public ASRReplicationProtectedItem ReplicationProtectedItem { get; set; }

        #endregion Parameters

        /// <summary>
        /// ProcessRecord of the command.
        /// </summary>
        public override void ExecuteSiteRecoveryCmdlet()
        {
            base.ExecuteSiteRecoveryCmdlet();
            switch (this.ParameterSetName)
            {
                case ASRParameterSets.ByPEObject:
                    this.protectionContainerName = 
                        Utilities.GetValueFromArmId(this.ReplicationProtectedItem.ID, ARMResourceTypeConstants.ReplicationProtectionContainers);
                    this.fabricName = Utilities.GetValueFromArmId(this.ReplicationProtectedItem.ID, ARMResourceTypeConstants.ReplicationFabrics);
                    this.SetPECommit();
                    break;
                case ASRParameterSets.ByRPObject:
                    this.StartRpCommit();
                    break;
            }
        }

        /// <summary>
        /// Start PE Commit.
        /// </summary>
        private void SetPECommit()
        {
            LongRunningOperationResponse response = RecoveryServicesClient.StartAzureSiteRecoveryCommitFailover(
                this.fabricName,
                this.protectionContainerName,
                this.ReplicationProtectedItem.Name);

            JobResponse jobResponse =
                RecoveryServicesClient
                .GetAzureSiteRecoveryJobDetails(PSRecoveryServicesClient.GetJobIdFromReponseLocation(response.Location));

            WriteObject(new ASRJob(jobResponse.Job));
        }

        /// <summary>
        /// Starts RP Commit.
        /// </summary>
        private void StartRpCommit()
        {
            LongRunningOperationResponse response = RecoveryServicesClient.StartAzureSiteRecoveryCommitFailover(
                this.RecoveryPlan.Name);

            JobResponse jobResponse =
                RecoveryServicesClient
                .GetAzureSiteRecoveryJobDetails(PSRecoveryServicesClient.GetJobIdFromReponseLocation(response.Location));

            WriteObject(new ASRJob(jobResponse.Job));
        }
    }
}