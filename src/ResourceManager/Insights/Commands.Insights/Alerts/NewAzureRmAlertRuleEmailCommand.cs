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

using Microsoft.Azure.Management.Monitor.Management.Models;
using System;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Insights.Alerts
{
    /// <summary>
    /// Create an AlertRuleWebhook action
    /// </summary>
    [Cmdlet(VerbsCommon.New, "AzureRmAlertRuleEmail"), OutputType(typeof(RuleEmailAction))]
    public class NewAzureRmAlertRuleEmailCommand : MonitorCmdletBase
    {
        /// <summary>
        /// Gets or sets the CustomEmails list of the action. A comma-separated list of e-mail addresses
        /// </summary>
        [Parameter(Position = 0, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The list of custom e-mails")]
        [ValidateNotNullOrEmpty]
        [Alias("CustomEmails")]
        public string[] CustomEmail { get; set; }

        /// <summary>
        /// Gets or sets the SendToServiceOwners flag of the action
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The send to service owner flag")]
        [Alias("SendToServiceOwners")]
        public SwitchParameter SendToServiceOwner { get; set; }

        /// <summary>
        /// Executes the Cmdlet. This is a callback function to simplify the exception handling
        /// </summary>
        protected override void ProcessRecordInternal()
        { }

        /// <summary>
        /// Execute the cmdlet
        /// </summary>
        public override void ExecuteCmdlet()
        {
            this.WriteIdentifiedWarning(
                cmdletName: "New-AzureRmAlertRuleEmail",
                topic: "Parameter name change",
                message: "The parameter plural names for the parameters will be deprecated in a future breaking change release in favor of the singular versions of the same names.");
            if (!this.SendToServiceOwner && (this.CustomEmail == null || this.CustomEmail.Length < 1))
            {
                throw new ArgumentException("Either SendToServiceOwners must be set or at least one custom email must be present");
            }

            var action = new RuleEmailAction
            {
                CustomEmails = this.CustomEmail,
                SendToServiceOwners = this.SendToServiceOwner
            };

            WriteObject(action);
        }
    }
}
