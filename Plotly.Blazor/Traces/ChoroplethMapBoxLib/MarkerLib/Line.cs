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

namespace Plotly.Blazor.Traces.ChoroplethMapBoxLib.MarkerLib
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Sets the marker.line color. It accepts either a specific color or an array
        ///     of numbers that are mapped to the colorscale relative to the max and min
        ///     values of the array or relative to <c>marker.line.cmin</c> and <c>marker.line.cmax</c>
        ///     if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the marker.line color. It accepts either a specific color or an array
        ///     of numbers that are mapped to the colorscale relative to the max and min
        ///     values of the array or relative to <c>marker.line.cmin</c> and <c>marker.line.cmax</c>
        ///     if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public IList<object> ColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>color</c>.
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the lines bounding the marker points.
        /// </summary>
        [JsonPropertyName(@"width")]
        public decimal? Width { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the lines bounding the marker points.
        /// </summary>
        [JsonPropertyName(@"width")]
        [Array]
        public IList<decimal?> WidthArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>width</c>.
        /// </summary>
        [JsonPropertyName(@"widthsrc")]
        public string WidthSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Line other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Line other)
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
                    Equals(ColorArray, other.ColorArray) ||
                    ColorArray != null && other.ColorArray != null &&
                    ColorArray.SequenceEqual(other.ColorArray)
                ) &&
                (
                    ColorSrc == other.ColorSrc ||
                    ColorSrc != null &&
                    ColorSrc.Equals(other.ColorSrc)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                ) && 
                (
                    Equals(WidthArray, other.WidthArray) ||
                    WidthArray != null && other.WidthArray != null &&
                    WidthArray.SequenceEqual(other.WidthArray)
                ) &&
                (
                    WidthSrc == other.WidthSrc ||
                    WidthSrc != null &&
                    WidthSrc.Equals(other.WidthSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ColorArray != null) hashCode = hashCode * 59 + ColorArray.GetHashCode();
                if (ColorSrc != null) hashCode = hashCode * 59 + ColorSrc.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                if (WidthArray != null) hashCode = hashCode * 59 + WidthArray.GetHashCode();
                if (WidthSrc != null) hashCode = hashCode * 59 + WidthSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Line left, Line right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Line left, Line right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Line</returns>
        public Line DeepClone()
        {
            return this.Copy();
        }
    }
}