// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of a managed hosting environment
    /// </summary>
    public partial class ManagedHostingEnvironment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedHostingEnvironment class.
        /// </summary>
        public ManagedHostingEnvironment() { }

        /// <summary>
        /// Initializes a new instance of the ManagedHostingEnvironment class.
        /// </summary>
        public ManagedHostingEnvironment(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string managedHostingEnvironmentName = default(string), string managedHostingEnvironmentLocation = default(string), ManagedHostingEnvironmentStatus? status = default(ManagedHostingEnvironmentStatus?), VirtualNetworkProfile virtualNetwork = default(VirtualNetworkProfile), int? ipsslAddressCount = default(int?), string dnsSuffix = default(string), string subscriptionId = default(string), string resourceGroup = default(string), bool? environmentIsHealthy = default(bool?), string environmentStatus = default(string), bool? suspended = default(bool?), string apiManagementAccount = default(string))
            : base(location, id, name, type, tags)
        {
            ManagedHostingEnvironmentName = managedHostingEnvironmentName;
            ManagedHostingEnvironmentLocation = managedHostingEnvironmentLocation;
            Status = status;
            VirtualNetwork = virtualNetwork;
            IpsslAddressCount = ipsslAddressCount;
            DnsSuffix = dnsSuffix;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            EnvironmentIsHealthy = environmentIsHealthy;
            EnvironmentStatus = environmentStatus;
            Suspended = suspended;
            ApiManagementAccount = apiManagementAccount;
        }

        /// <summary>
        /// Name of the managed hosting environment
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string ManagedHostingEnvironmentName { get; set; }

        /// <summary>
        /// Location of the managed hosting environment e.g. "West US"
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string ManagedHostingEnvironmentLocation { get; set; }

        /// <summary>
        /// Current status of the managed hosting environment. Possible values
        /// for this property include: 'Preparing', 'Ready', 'Deleting'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public ManagedHostingEnvironmentStatus? Status { get; set; }

        /// <summary>
        /// Description of the managed hosting environment's virtual network
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetwork")]
        public VirtualNetworkProfile VirtualNetwork { get; set; }

        /// <summary>
        /// Number of ip ssl addresses reserved for the managed hosting
        /// environment
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsslAddressCount")]
        public int? IpsslAddressCount { get; set; }

        /// <summary>
        /// DNS suffix of the managed hosting environment
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSuffix")]
        public string DnsSuffix { get; set; }

        /// <summary>
        /// Subscription of the managed hosting environment (read only)
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Resource group of the managed hosting environment (read only)
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// True/false indicating whether the managed hosting environment is
        /// healthy
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentIsHealthy")]
        public bool? EnvironmentIsHealthy { get; set; }

        /// <summary>
        /// Detailed message about with results of the last check of the
        /// managed hosting environment
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentStatus")]
        public string EnvironmentStatus { get; set; }

        /// <summary>
        /// True/false indicating whether the managed hosting environment is
        /// suspended. The environment can be suspended e.g. when the
        /// management endpoint is no longer available
        /// (most likely because NSG blocked the incoming traffic)
        /// </summary>
        [JsonProperty(PropertyName = "properties.suspended")]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Resource id of the api management account associated with this
        /// managed hosting environment (read only)
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiManagementAccount")]
        public string ApiManagementAccount { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}