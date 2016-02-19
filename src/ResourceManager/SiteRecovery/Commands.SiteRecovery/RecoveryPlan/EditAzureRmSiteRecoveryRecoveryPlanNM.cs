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
using System.ComponentModel;
using System.Management.Automation;
using Microsoft.Azure.Management.SiteRecovery.Models;
using Microsoft.Azure.Portal.RecoveryServices.Models.Common;
using Properties = Microsoft.Azure.Commands.SiteRecovery.Properties;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.SiteRecovery
{
    /// <summary>
    /// Updates Azure Site Recovery Recovery Plan object in memory.
    /// </summary>
    [Cmdlet(VerbsData.Edit, "AzureRmSiteRecoveryRecoveryPlanNM", DefaultParameterSetName = ASRParameterSets.AppendGroup)]
    public class EditAzureRmSiteRecoveryRecoveryPlanNM : SiteRecoveryCmdletBase
    {
        #region Parameters

        /// <summary>
        /// Gets or sets Name of the Recovery Plan.
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public ASRRecoveryPlan RecoveryPlan { get; set; }

        /// <summary>
        /// Gets or sets switch parameter
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.AppendGroup, Mandatory = true)]
        public SwitchParameter AppendGroup { get; set; }

        /// <summary>
        /// Gets or sets switch parameter
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.RemoveGroup, Mandatory = true)]
        public ASRRecoveryPlanGroup RemoveGroup { get; set; }

        /// <summary>
        /// Gets or sets group
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.AddProtectedEntities, Mandatory = true)]
        [Parameter(ParameterSetName = ASRParameterSets.RemoveProtectedEntities, Mandatory = true)]
        public ASRRecoveryPlanGroup Group { get; set; }

        /// <summary>
        /// Gets or sets switch parameter
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.AddProtectedEntities, Mandatory = true)]
        public ASRReplicationProtectedItem [] AddProtectedItems { get; set; }

        /// <summary>
        /// Gets or sets switch parameter
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.RemoveProtectedEntities, Mandatory = true)]
        public ASRReplicationProtectedItem [] RemoveProtectedItems { get; set; }

        #endregion Parameters

        /// <summary>
        /// ProcessRecord of the command.
        /// </summary>
        public override void ExecuteSiteRecoveryCmdlet()
        {
            base.ExecuteSiteRecoveryCmdlet();

            ASRRecoveryPlanGroup tempGroup;

            switch (this.ParameterSetName)
            {
                case ASRParameterSets.AppendGroup:
                    RecoveryPlanGroup recoveryPlanGroup = new RecoveryPlanGroup()
                    {
                        GroupType = Constants.Boot,
                        ReplicationProtectedItems = new List<RecoveryPlanProtectedItem>(),
                        StartGroupActions = new List<RecoveryPlanAction>(),
                        EndGroupActions = new List<RecoveryPlanAction>()
                    };

                    this.RecoveryPlan.Groups.Add(new ASRRecoveryPlanGroup("Group " + (RecoveryPlan.Groups.Count - 1).ToString(), recoveryPlanGroup));
                    break;
                case ASRParameterSets.RemoveGroup:
                    tempGroup = this.RecoveryPlan.Groups.FirstOrDefault(g => String.CompareOrdinal(g.Name, RemoveGroup.Name) == 0);

                    if (tempGroup != null)
                    {
                        this.RecoveryPlan.Groups.Remove(tempGroup);
                        this.RecoveryPlan = this.RecoveryPlan.RefreshASRRecoveryPlanGroupNames();
                    }
                    else
                    {
                        throw new PSArgumentException(string.Format(Properties.Resources.GroupNotFoundInRecoveryPlan, this.RemoveGroup.Name, this.RecoveryPlan.FriendlyName));
                    }

                    break;
                case ASRParameterSets.AddProtectedEntities:
                    foreach (ASRReplicationProtectedItem rpi in AddProtectedItems)
                    {
                        string fabricName = Utilities.GetValueFromArmId(rpi.ID, ARMResourceTypeConstants.ReplicationFabrics);

                        ReplicationProtectedItemResponse replicationProtectedItemResponse =
                        RecoveryServicesClient.GetAzureSiteRecoveryReplicationProtectedItem(fabricName,
                        Utilities.GetValueFromArmId(rpi.ID, ARMResourceTypeConstants.ReplicationProtectionContainers), 
                        rpi.Name);

                        tempGroup = this.RecoveryPlan.Groups.FirstOrDefault(g => String.Compare(g.Name, Group.Name, StringComparison.OrdinalIgnoreCase) == 0);

                        if (tempGroup != null)
                        {
                            foreach (ASRRecoveryPlanGroup gp in this.RecoveryPlan.Groups)
                            {
                                if (gp.ReplicationProtectedItems.Any(pi => String.CompareOrdinal(pi.Id, replicationProtectedItemResponse.ReplicationProtectedItem.Id) == 0))
                                {
                                    throw new PSArgumentException(string.Format(Properties.Resources.VMAlreadyPartOfGroup, rpi.FriendlyName, gp.Name, this.RecoveryPlan.FriendlyName));
                                }
                            }

                            this.RecoveryPlan.Groups[RecoveryPlan.Groups.IndexOf(tempGroup)].ReplicationProtectedItems.Add(replicationProtectedItemResponse.ReplicationProtectedItem);
                        }
                        else
                        {
                            throw new PSArgumentException(string.Format(Properties.Resources.GroupNotFoundInRecoveryPlan, this.Group.Name, this.RecoveryPlan.FriendlyName));
                        }
                    }
                    break;
                case ASRParameterSets.RemoveProtectedEntities:
                    foreach (ASRReplicationProtectedItem rpi in RemoveProtectedItems)
                    {
                        string fabricName = Utilities.GetValueFromArmId(rpi.ID, ARMResourceTypeConstants.ReplicationFabrics);

                        ReplicationProtectedItemResponse replicationProtectedItemResponse =
                        RecoveryServicesClient.GetAzureSiteRecoveryReplicationProtectedItem(fabricName,
                        Utilities.GetValueFromArmId(rpi.ID, ARMResourceTypeConstants.ReplicationProtectionContainers), 
                        rpi.Name);

                        tempGroup = this.RecoveryPlan.Groups.FirstOrDefault(g => String.Compare(g.Name, Group.Name, StringComparison.OrdinalIgnoreCase) == 0);

                        if (tempGroup != null)
                        {
                            var ReplicationProtectedItem =
                                this.RecoveryPlan.Groups[RecoveryPlan.Groups.IndexOf(tempGroup)].ReplicationProtectedItems.
                                FirstOrDefault(pi => String.CompareOrdinal(pi.Id, replicationProtectedItemResponse.ReplicationProtectedItem.Id) == 0);

                            if (ReplicationProtectedItem != null)
                            {
                                this.RecoveryPlan.Groups[RecoveryPlan.Groups.IndexOf(tempGroup)].ReplicationProtectedItems.Remove(ReplicationProtectedItem);
                            }
                            else
                            {
                                throw new PSArgumentException(string.Format(Properties.Resources.VMNotFoundInGroup, rpi.FriendlyName, this.Group.Name, this.RecoveryPlan.FriendlyName));
                            }
                        }
                        else
                        {
                            throw new PSArgumentException(string.Format(Properties.Resources.GroupNotFoundInRecoveryPlan, this.Group.Name, this.RecoveryPlan.FriendlyName));
                        }
                    }
                    break;
            };

            this.WriteObject(this.RecoveryPlan);
        }
    }
}
