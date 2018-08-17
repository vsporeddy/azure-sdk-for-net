// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A failover group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FailoverGroup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the FailoverGroup class.
        /// </summary>
        public FailoverGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FailoverGroup class.
        /// </summary>
        /// <param name="readWriteEndpoint">Read-write endpoint of the failover
        /// group instance.</param>
        /// <param name="partnerServers">List of partner server information for
        /// the failover group.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="readOnlyEndpoint">Read-only endpoint of the failover
        /// group instance.</param>
        /// <param name="replicationRole">Local replication role of the
        /// failover group instance. Possible values include: 'Primary',
        /// 'Secondary'</param>
        /// <param name="replicationState">Replication state of the failover
        /// group instance.</param>
        /// <param name="databases">List of databases in the failover
        /// group.</param>
        public FailoverGroup(FailoverGroupReadWriteEndpoint readWriteEndpoint, IList<PartnerInfo> partnerServers, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), FailoverGroupReadOnlyEndpoint readOnlyEndpoint = default(FailoverGroupReadOnlyEndpoint), FailoverGroupReplicationRole? replicationRole = default(FailoverGroupReplicationRole?), string replicationState = default(string), IList<string> databases = default(IList<string>))
            : base(id, name, type)
        {
            Location = location;
            Tags = tags;
            ReadWriteEndpoint = readWriteEndpoint;
            ReadOnlyEndpoint = readOnlyEndpoint;
            ReplicationRole = replicationRole;
            ReplicationState = replicationState;
            PartnerServers = partnerServers;
            Databases = databases;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets read-write endpoint of the failover group instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readWriteEndpoint")]
        public FailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }

        /// <summary>
        /// Gets or sets read-only endpoint of the failover group instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readOnlyEndpoint")]
        public FailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }

        /// <summary>
        /// Gets local replication role of the failover group instance.
        /// Possible values include: 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationRole")]
        public FailoverGroupReplicationRole? ReplicationRole { get; private set; }

        /// <summary>
        /// Gets replication state of the failover group instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationState")]
        public string ReplicationState { get; private set; }

        /// <summary>
        /// Gets or sets list of partner server information for the failover
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerServers")]
        public IList<PartnerInfo> PartnerServers { get; set; }

        /// <summary>
        /// Gets or sets list of databases in the failover group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databases")]
        public IList<string> Databases { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReadWriteEndpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReadWriteEndpoint");
            }
            if (PartnerServers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PartnerServers");
            }
            if (ReadWriteEndpoint != null)
            {
                ReadWriteEndpoint.Validate();
            }
            if (PartnerServers != null)
            {
                foreach (var element in PartnerServers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
