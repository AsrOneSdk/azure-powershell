// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support
{

    public partial struct AbsoluteMarker :
        System.IEquatable<AbsoluteMarker>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker AllBackup = @"AllBackup";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker FirstOfDay = @"FirstOfDay";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker FirstOfMonth = @"FirstOfMonth";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker FirstOfWeek = @"FirstOfWeek";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker FirstOfYear = @"FirstOfYear";

        /// <summary>the value for an instance of the <see cref="AbsoluteMarker" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AbsoluteMarker" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AbsoluteMarker(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AbsoluteMarker</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AbsoluteMarker" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AbsoluteMarker(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AbsoluteMarker</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AbsoluteMarker (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AbsoluteMarker && Equals((AbsoluteMarker)obj);
        }

        /// <summary>Returns hashCode for enum AbsoluteMarker</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AbsoluteMarker</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AbsoluteMarker</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AbsoluteMarker" />.</param>

        public static implicit operator AbsoluteMarker(string value)
        {
            return new AbsoluteMarker(value);
        }

        /// <summary>Implicit operator to convert AbsoluteMarker to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AbsoluteMarker" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AbsoluteMarker</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AbsoluteMarker</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AbsoluteMarker e2)
        {
            return e2.Equals(e1);
        }
    }
}