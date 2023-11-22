/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.HistogramLib
{
    /// <summary>
    ///     The OutsideTextFont class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class OutsideTextFont : IEquatable<OutsideTextFont>
    {
        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     HTML font family - the typeface that will be applied by the web browser.
        ///     The web browser will only be able to apply a font if it is available on
        ///     the system which it operates. Provide multiple font families, separated
        ///     by commas, to indicate the preference in which to apply fonts if they aren&#39;t
        ///     available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com
        ///     or on-premise) generates images on a server, where only a select number
        ///     of fonts are installed and supported. These include <c>Arial</c>, <c>Balto</c>,
        ///     &#39;Courier New&#39;, &#39;Droid Sans&#39;,, &#39;Droid Serif&#39;, &#39;Droid
        ///     Sans Mono&#39;, &#39;Gravitas One&#39;, &#39;Old Standard TT&#39;, &#39;Open
        ///     Sans&#39;, <c>Overpass</c>, &#39;PT Sans Narrow&#39;, <c>Raleway</c>, &#39;Times
        ///     New Roman&#39;.
        /// </summary>
        [JsonPropertyName(@"family")]
        public string Family { get; set;} 

        /// <summary>
        ///     Gets or sets the Size.
        /// </summary>
        [JsonPropertyName(@"size")]
        public decimal? Size { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is OutsideTextFont other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] OutsideTextFont other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Family == other.Family ||
                    Family != null &&
                    Family.Equals(other.Family)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Family != null) hashCode = hashCode * 59 + Family.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left OutsideTextFont and the right OutsideTextFont.
        /// </summary>
        /// <param name="left">Left OutsideTextFont.</param>
        /// <param name="right">Right OutsideTextFont.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (OutsideTextFont left, OutsideTextFont right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left OutsideTextFont and the right OutsideTextFont.
        /// </summary>
        /// <param name="left">Left OutsideTextFont.</param>
        /// <param name="right">Right OutsideTextFont.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (OutsideTextFont left, OutsideTextFont right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>OutsideTextFont</returns>
        public OutsideTextFont DeepClone()
        {
            return this.Copy();
        }
    }
}