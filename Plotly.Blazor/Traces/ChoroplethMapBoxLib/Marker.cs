/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ChoroplethMapBoxLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ChoroplethMapBoxLib.MarkerLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the opacity of the locations.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Sets the opacity of the locations.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        [Array]
        public IList<decimal?> OpacityArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>opacity</c>.
        /// </summary>
        [JsonPropertyName(@"opacitysrc")]
        public string OpacitySrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Marker other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Marker other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Equals(OpacityArray, other.OpacityArray) ||
                    OpacityArray != null && other.OpacityArray != null &&
                    OpacityArray.SequenceEqual(other.OpacityArray)
                ) &&
                (
                    OpacitySrc == other.OpacitySrc ||
                    OpacitySrc != null &&
                    OpacitySrc.Equals(other.OpacitySrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (OpacityArray != null) hashCode = hashCode * 59 + OpacityArray.GetHashCode();
                if (OpacitySrc != null) hashCode = hashCode * 59 + OpacitySrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Marker left, Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Marker left, Marker right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Marker</returns>
        public Marker DeepClone()
        {
            return this.Copy();
        }
    }
}