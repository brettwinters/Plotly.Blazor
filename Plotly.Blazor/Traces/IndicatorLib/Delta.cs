/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.IndicatorLib
{
    /// <summary>
    ///     The Delta class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class Delta : IEquatable<Delta>
    {
        /// <summary>
        ///     Gets or sets the Decreasing.
        /// </summary>
        [JsonPropertyName(@"decreasing")]
        public Plotly.Blazor.Traces.IndicatorLib.DeltaLib.Decreasing Decreasing { get; set;} 

        /// <summary>
        ///     Set the font used to display the delta
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.IndicatorLib.DeltaLib.Font Font { get; set;} 

        /// <summary>
        ///     Gets or sets the Increasing.
        /// </summary>
        [JsonPropertyName(@"increasing")]
        public Plotly.Blazor.Traces.IndicatorLib.DeltaLib.Increasing Increasing { get; set;} 

        /// <summary>
        ///     Sets the position of delta with respect to the number.
        /// </summary>
        [JsonPropertyName(@"position")]
        public Plotly.Blazor.Traces.IndicatorLib.DeltaLib.PositionEnum? Position { get; set;} 

        /// <summary>
        ///     Sets a prefix appearing before the delta.
        /// </summary>
        [JsonPropertyName(@"prefix")]
        public string Prefix { get; set;} 

        /// <summary>
        ///     Sets the reference value to compute the delta. By default, it is set to
        ///     the current value.
        /// </summary>
        [JsonPropertyName(@"reference")]
        public decimal? Reference { get; set;} 

        /// <summary>
        ///     Show relative change
        /// </summary>
        [JsonPropertyName(@"relative")]
        public bool? Relative { get; set;} 

        /// <summary>
        ///     Sets a suffix appearing next to the delta.
        /// </summary>
        [JsonPropertyName(@"suffix")]
        public string Suffix { get; set;} 

        /// <summary>
        ///     Sets the value formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format.
        /// </summary>
        [JsonPropertyName(@"valueformat")]
        public string ValueFormat { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Delta other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Delta other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Decreasing == other.Decreasing ||
                    Decreasing != null &&
                    Decreasing.Equals(other.Decreasing)
                ) && 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Increasing == other.Increasing ||
                    Increasing != null &&
                    Increasing.Equals(other.Increasing)
                ) && 
                (
                    Position == other.Position ||
                    Position != null &&
                    Position.Equals(other.Position)
                ) && 
                (
                    Prefix == other.Prefix ||
                    Prefix != null &&
                    Prefix.Equals(other.Prefix)
                ) && 
                (
                    Reference == other.Reference ||
                    Reference != null &&
                    Reference.Equals(other.Reference)
                ) && 
                (
                    Relative == other.Relative ||
                    Relative != null &&
                    Relative.Equals(other.Relative)
                ) && 
                (
                    Suffix == other.Suffix ||
                    Suffix != null &&
                    Suffix.Equals(other.Suffix)
                ) && 
                (
                    ValueFormat == other.ValueFormat ||
                    ValueFormat != null &&
                    ValueFormat.Equals(other.ValueFormat)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Decreasing != null) hashCode = hashCode * 59 + Decreasing.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Increasing != null) hashCode = hashCode * 59 + Increasing.GetHashCode();
                if (Position != null) hashCode = hashCode * 59 + Position.GetHashCode();
                if (Prefix != null) hashCode = hashCode * 59 + Prefix.GetHashCode();
                if (Reference != null) hashCode = hashCode * 59 + Reference.GetHashCode();
                if (Relative != null) hashCode = hashCode * 59 + Relative.GetHashCode();
                if (Suffix != null) hashCode = hashCode * 59 + Suffix.GetHashCode();
                if (ValueFormat != null) hashCode = hashCode * 59 + ValueFormat.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Delta and the right Delta.
        /// </summary>
        /// <param name="left">Left Delta.</param>
        /// <param name="right">Right Delta.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Delta left, Delta right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Delta and the right Delta.
        /// </summary>
        /// <param name="left">Left Delta.</param>
        /// <param name="right">Right Delta.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Delta left, Delta right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Delta</returns>
        public Delta DeepClone()
        {
            return this.Copy();
        }
    }
}