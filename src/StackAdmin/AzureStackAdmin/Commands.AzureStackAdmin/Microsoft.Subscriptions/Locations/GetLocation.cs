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

namespace Microsoft.AzureStack.Commands
{
    using System;
    using System.Management.Automation;
    using Microsoft.WindowsAzure.Commands.Common;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Models;

    /// <summary>
    /// Remove managed location cmdlet
    /// </summary>
    [Cmdlet(VerbsCommon.Get, Nouns.Location)]
    [OutputType(typeof(Location))]
    [Alias("Get-AzureRmManagedLocation")]
    public class GetLocation : AdminApiCmdlet
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Parameter]
        [ValidateLength(1, 128)]
        [ValidateNotNull]
        [ValidatePattern("^[0-9a-z]+$")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the managed location 
        /// </summary>
        protected override void ExecuteCore()
        {
            if (this.MyInvocation.InvocationName.Equals("Get-AzureRmManagedLocation", StringComparison.OrdinalIgnoreCase))
            {
                this.WriteWarning("Alias Get-AzureRmManagedLocation will be deprecated in a future release. Please use the cmdlet name Get-AzsLocation instead");
            }

            using (var client = this.GetAzureStackClient())
            {
                if (string.IsNullOrEmpty(this.Name))
                {
                    this.WriteVerbose(Resources.ListingLocations);
                    var result = client.ManagedLocations.List().Locations;
                    WriteObject(result, enumerateCollection: true);
                }
                else
                {
                    this.WriteVerbose(Resources.GettingLocation.FormatArgs(this.Name));
                    var result = client.ManagedLocations.Get(this.Name).Location;
                    WriteObject(result);
                }
            }
        }
    }
}
