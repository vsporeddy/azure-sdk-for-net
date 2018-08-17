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
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ManagedDatabaseStatus.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ManagedDatabaseStatusConverter))]
    public struct ManagedDatabaseStatus : System.IEquatable<ManagedDatabaseStatus>
    {
        private ManagedDatabaseStatus(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ManagedDatabaseStatus Online = "Online";

        public static readonly ManagedDatabaseStatus Offline = "Offline";

        public static readonly ManagedDatabaseStatus Shutdown = "Shutdown";

        public static readonly ManagedDatabaseStatus Creating = "Creating";

        public static readonly ManagedDatabaseStatus Inaccessible = "Inaccessible";


        /// <summary>
        /// Underlying value of enum ManagedDatabaseStatus
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ManagedDatabaseStatus
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ManagedDatabaseStatus
        /// </summary>
        public bool Equals(ManagedDatabaseStatus e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ManagedDatabaseStatus
        /// </summary>
        public static implicit operator ManagedDatabaseStatus(string value)
        {
            return new ManagedDatabaseStatus(value);
        }

        /// <summary>
        /// Implicit operator to convert ManagedDatabaseStatus to string
        /// </summary>
        public static implicit operator string(ManagedDatabaseStatus e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ManagedDatabaseStatus
        /// </summary>
        public static bool operator == (ManagedDatabaseStatus e1, ManagedDatabaseStatus e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ManagedDatabaseStatus
        /// </summary>
        public static bool operator != (ManagedDatabaseStatus e1, ManagedDatabaseStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ManagedDatabaseStatus
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ManagedDatabaseStatus && Equals((ManagedDatabaseStatus)obj);
        }

        /// <summary>
        /// Returns for hashCode ManagedDatabaseStatus
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
