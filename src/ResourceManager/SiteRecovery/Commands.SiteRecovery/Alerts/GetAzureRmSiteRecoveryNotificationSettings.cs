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

using Microsoft.Azure.Management.SiteRecovery.Models;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.SiteRecovery
{
    /// <summary>
    /// Retrieves Azure Site Recovery alert and nofification settings.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureRmSiteRecoveryNotificationSettings",
        DefaultParameterSetName = ASRParameterSets.Default)]
    [OutputType(typeof(IEnumerable<ASRAlertSettings>))]
    public class GetAzureRmSiteRecoveryNotificationSettings : SiteRecoveryCmdletBase
    {
        #region Parameters
        #endregion Parameters

        /// <summary>
        /// ProcessRecord of the command.
        /// </summary>
        public override void ExecuteSiteRecoveryCmdlet()
        {
            base.ExecuteSiteRecoveryCmdlet();
            this.GetAlertSettings();
        }

        /// <summary>
        /// Gets the alert and notification settings.
        /// </summary>
        private void GetAlertSettings()
        {
            AlertSettingsListResponse alertSettings =
                RecoveryServicesClient.GetAzureRmSiteRecoveryNotificationSettings();
            this.WriteAlerts(alertSettings.Alerts);
        }

        /// <summary>
        /// Write Alert settings.
        /// </summary>
        /// <param name="alertSettings">List of alert settings.</param>
        private void WriteAlerts(IList<AlertSettings> alertSettings)
        {
            this.WriteObject(alertSettings.Select(p => new ASRAlertSettings(p)), true);
        }
    }
}