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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Commands.SiteRecovery
{
    /// <summary>
    /// Recovery services convenience client.
    /// </summary>
    [SuppressMessage(
        "Microsoft.StyleCop.CSharp.MaintainabilityRules",
        "SA1402:FileMayOnlyContainASingleClass",
        Justification = "Keeping all contracts together.")]
    public partial class PSRecoveryServicesClient
    {
        /// <summary>
        /// Gets all Azure Site Recovery Network mappings.
        /// </summary>
        /// <returns>Network mappings list response.</returns>
        public NetworkMappingsListResponse GetAzureSiteRecoveryNetworkMappings()
        {
            return this.GetSiteRecoveryClient()
                .NetworkMapping
                .GetAll(this.GetRequestHeaders());
        }

        /// <summary>
        /// Gets all Azure Site Recovery Network mappings for the specified primary network.
        /// </summary>
        /// <param name="primaryFabricName">Primary fabric name.</param>
        /// <param name="primaryNetworkName">Primary network name.</param>
        /// <returns>Network mappings list response.</returns>
        public NetworkMappingsListResponse GetAzureSiteRecoveryNetworkMappings(
            string primaryFabricName,
            string primaryNetworkName)
        {
            return this.GetSiteRecoveryClient()
                .NetworkMapping
                .List(primaryFabricName,primaryNetworkName, this.GetRequestHeaders());
        }

        /// <summary>
        /// Gets Azure Site Recovery Network mapping for the specified network and resource name.
        /// </summary>
        /// <param name="primaryFabricName">Primary fabric name.</param>
        /// <param name="primaryNetworkName">Primary network name.</param>
        /// <param name="mappingName">Mapping ARM resource name.</param>
        /// <returns>Network mappings list response.</returns>
        public NetworkMappingResponse GetAzureSiteRecoveryNetworkMappings(
            string primaryFabricName,
            string primaryNetworkName,
            string mappingName)
        {
            return this.GetSiteRecoveryClient()
                .NetworkMapping
                .Get(primaryFabricName, primaryNetworkName, mappingName, this.GetRequestHeaders());
        }

        /// <summary>
        /// Creates a new Azure Site Recovery Network mapping.
        /// </summary>
        /// <param name="primaryFabricName">Primary fabric name.</param>
        /// <param name="primaryNetworkName">Primary network name.</param>
        /// <param name="mappingName">Mapping name.</param>
        /// <param name="input">Input data to be passed as request body.</param>
        /// <returns>Long running operation response.</returns>
        public LongRunningOperationResponse NewAzureSiteRecoveryNetworkMapping(
            string primaryFabricName,
            string primaryNetworkName,
            string mappingName,
            CreateNetworkMappingInput input)
        {
            return this.GetSiteRecoveryClient()
                .NetworkMapping
                .BeginCreating(
                    primaryFabricName,
                    primaryNetworkName,
                    mappingName,
                    input,
                    this.GetRequestHeaders());
        }

        /// <summary>
        /// Updates an existing Azure Site Recovery Network mapping.
        /// </summary>
        /// <param name="primaryFabricName">Primary fabric name.</param>
        /// <param name="primaryNetworkName">Primary network name.</param>
        /// <param name="mappingName">Mapping name.</param>
        /// <param name="input">Input data to be passed as request body.</param>
        /// <returns>Long running operation response.</returns>
        public LongRunningOperationResponse UpdateAzureSiteRecoveryNetworkMapping(
            string primaryFabricName,
            string primaryNetworkName,
            string mappingName,
            UpdateNetworkMappingInput input)
        {
            return this.GetSiteRecoveryClient()
                .NetworkMapping
                .BeginUpdating(
                    primaryFabricName,
                    primaryNetworkName,
                    mappingName,
                    input,
                    this.GetRequestHeaders());
        }

        /// <summary>
        /// Removes Azure Site Recovery Network Mapping.
        /// </summary>
        /// <param name="primaryFabricName">Primary fabric name.</param>
        /// <param name="primaryNetworkName">Primary network name.</param>
        /// <param name="mappingName">mapping name.</param>
        /// <returns>Long running operation response.</returns>
        public LongRunningOperationResponse RemoveAzureSiteRecoveryNetworkMapping(
            string primaryFabricName,
            string primaryNetworkName,
            string mappingName)
        {
            return this.GetSiteRecoveryClient()
                .NetworkMapping
                .BeginDeleting(
                    primaryFabricName,
                    primaryNetworkName,
                    mappingName,
                    this.GetRequestHeaders());
        }
    }
}