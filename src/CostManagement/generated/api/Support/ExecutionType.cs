// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>The type of the export execution.</summary>
    public partial struct ExecutionType :
        System.IEquatable<ExecutionType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType OnDemand = @"OnDemand";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType Scheduled = @"Scheduled";

        /// <summary>the value for an instance of the <see cref="ExecutionType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ExecutionType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExecutionType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ExecutionType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ExecutionType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ExecutionType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ExecutionType && Equals((ExecutionType)obj);
        }

        /// <summary>Creates an instance of the <see cref="ExecutionType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ExecutionType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum ExecutionType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ExecutionType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ExecutionType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExecutionType" />.</param>

        public static implicit operator ExecutionType(string value)
        {
            return new ExecutionType(value);
        }

        /// <summary>Implicit operator to convert ExecutionType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ExecutionType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ExecutionType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ExecutionType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExecutionType e2)
        {
            return e2.Equals(e1);
        }
    }
}