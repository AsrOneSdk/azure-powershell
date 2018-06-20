// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version_2018_04.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the availability set that the virtual
    /// machine should be assigned to. Only tags may be updated.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AvailabilitySetUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the AvailabilitySetUpdate class.
        /// </summary>
        public AvailabilitySetUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailabilitySetUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="platformUpdateDomainCount">Update Domain
        /// count.</param>
        /// <param name="platformFaultDomainCount">Fault Domain count.</param>
        /// <param name="virtualMachines">A list of references to all virtual
        /// machines in the availability set.</param>
        /// <param name="statuses">The resource status information.</param>
        /// <param name="sku">Sku of the availability set</param>
        public AvailabilitySetUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), int? platformUpdateDomainCount = default(int?), int? platformFaultDomainCount = default(int?), IList<SubResource> virtualMachines = default(IList<SubResource>), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>), Sku sku = default(Sku))
            : base(tags)
        {
            PlatformUpdateDomainCount = platformUpdateDomainCount;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachines = virtualMachines;
            Statuses = statuses;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets update Domain count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformUpdateDomainCount")]
        public int? PlatformUpdateDomainCount { get; set; }

        /// <summary>
        /// Gets or sets fault Domain count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformFaultDomainCount")]
        public int? PlatformFaultDomainCount { get; set; }

        /// <summary>
        /// Gets or sets a list of references to all virtual machines in the
        /// availability set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachines")]
        public IList<SubResource> VirtualMachines { get; set; }

        /// <summary>
        /// Gets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statuses")]
        public IList<InstanceViewStatus> Statuses { get; private set; }

        /// <summary>
        /// Gets or sets sku of the availability set
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

    }
}
