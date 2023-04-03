/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.NewShapeLib
{
    /// <summary>
    ///     The Label class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Label : IEquatable<Label>
    {
        /// <summary>
        ///     Sets the new shape label text font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.LabelLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets padding (in px) between edge of label and edge of new shape.
        /// </summary>
        [JsonPropertyName(@"padding")]
        public decimal? Padding { get; set;} 

        /// <summary>
        ///     Sets the text to display with the new shape.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the angle at which the label text is drawn with respect to the horizontal.
        ///     For lines, angle <c>auto</c> is the same angle as the line. For all other
        ///     shapes, angle <c>auto</c> is horizontal.
        /// </summary>
        [JsonPropertyName(@"textangle")]
        public decimal? TextAngle { get; set;} 

        /// <summary>
        ///     Sets the position of the label text relative to the new shape. Supported
        ///     values for rectangles, circles and paths are &#39;top left&#39;, &#39;top
        ///     center&#39;, &#39;top right&#39;, &#39;middle left&#39;, &#39;middle center&#39;,
        ///     &#39;middle right&#39;, &#39;bottom left&#39;, &#39;bottom center&#39;,
        ///     and &#39;bottom right&#39;. Supported values for lines are <c>start</c>,
        ///     <c>middle</c>, and <c>end</c>. Default: &#39;middle center&#39; for rectangles,
        ///     circles, and paths; <c>middle</c> for lines.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.LabelLib.TextPositionEnum? TextPosition { get; set;} 

        /// <summary>
        ///     Sets the label&#39;s horizontal position anchor This anchor binds the specified
        ///     <c>textposition</c> to the <c>left</c>, <c>center</c> or <c>right</c> of
        ///     the label text. For example, if <c>textposition</c> is set to &#39;top right&#39;
        ///     and <c>xanchor</c> to <c>right</c> then the right-most portion of the label
        ///     text lines up with the right-most edge of the new shape.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.LabelLib.XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the label&#39;s vertical position anchor This anchor binds the specified
        ///     <c>textposition</c> to the <c>top</c>, <c>middle</c> or <c>bottom</c> of
        ///     the label text. For example, if <c>textposition</c> is set to &#39;top right&#39;
        ///     and <c>yanchor</c> to <c>top</c> then the top-most portion of the label
        ///     text lines up with the top-most edge of the new shape.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.LabelLib.YAnchorEnum? YAnchor { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Label other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Label other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Padding == other.Padding ||
                    Padding != null &&
                    Padding.Equals(other.Padding)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    TextAngle == other.TextAngle ||
                    TextAngle != null &&
                    TextAngle.Equals(other.TextAngle)
                ) && 
                (
                    TextPosition == other.TextPosition ||
                    TextPosition != null &&
                    TextPosition.Equals(other.TextPosition)
                ) && 
                (
                    XAnchor == other.XAnchor ||
                    XAnchor != null &&
                    XAnchor.Equals(other.XAnchor)
                ) && 
                (
                    YAnchor == other.YAnchor ||
                    YAnchor != null &&
                    YAnchor.Equals(other.YAnchor)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Padding != null) hashCode = hashCode * 59 + Padding.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (TextAngle != null) hashCode = hashCode * 59 + TextAngle.GetHashCode();
                if (TextPosition != null) hashCode = hashCode * 59 + TextPosition.GetHashCode();
                if (XAnchor != null) hashCode = hashCode * 59 + XAnchor.GetHashCode();
                if (YAnchor != null) hashCode = hashCode * 59 + YAnchor.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Label and the right Label.
        /// </summary>
        /// <param name="left">Left Label.</param>
        /// <param name="right">Right Label.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Label left, Label right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Label and the right Label.
        /// </summary>
        /// <param name="left">Left Label.</param>
        /// <param name="right">Right Label.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Label left, Label right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Label</returns>
        public Label DeepClone()
        {
            return this.Copy();
        }
    }
}