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

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Slider class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class Slider : IEquatable<Slider>
    {
        /// <summary>
        ///     Determines which button (by index starting from 0) is considered active.
        /// </summary>
        [JsonPropertyName(@"active")]
        public decimal? Active { get; set;} 

        /// <summary>
        ///     Sets the background color of the slider grip while dragging.
        /// </summary>
        [JsonPropertyName(@"activebgcolor")]
        public object ActiveBgColor { get; set;} 

        /// <summary>
        ///     Sets the background color of the slider.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public decimal? BorderWidth { get; set;} 

        /// <summary>
        ///     Gets or sets the CurrentValue.
        /// </summary>
        [JsonPropertyName(@"currentvalue")]
        public Plotly.Blazor.LayoutLib.SliderLib.CurrentValue CurrentValue { get; set;} 

        /// <summary>
        ///     Sets the font of the slider step labels.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.LayoutLib.SliderLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets the length of the slider This measure excludes the padding of both
        ///     ends. That is, the slider&#39;s length is this length minus the padding
        ///     on both ends.
        /// </summary>
        [JsonPropertyName(@"len")]
        public decimal? Len { get; set;} 

        /// <summary>
        ///     Determines whether this slider length is set in units of plot <c>fraction</c>
        ///     or in *pixels. Use <c>len</c> to set the value.
        /// </summary>
        [JsonPropertyName(@"lenmode")]
        public Plotly.Blazor.LayoutLib.SliderLib.LenModeEnum? LenMode { get; set;} 

        /// <summary>
        ///     Sets the length in pixels of minor step tick marks
        /// </summary>
        [JsonPropertyName(@"minorticklen")]
        public decimal? MinorTickLen { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Set the padding of the slider component along each side.
        /// </summary>
        [JsonPropertyName(@"pad")]
        public Plotly.Blazor.LayoutLib.SliderLib.Pad Pad { get; set;} 

        /// <summary>
        ///     Gets or sets the Steps.
        /// </summary>
        [JsonPropertyName(@"steps")]
        public IList<Plotly.Blazor.LayoutLib.SliderLib.Step> Steps { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with <c>templateitemname</c>
        ///     matching its <c>name</c>, alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). If there is no template
        ///     or no matching item, this item will be hidden unless you explicitly show
        ///     it with &#39;visible: true&#39;.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set;} 

        /// <summary>
        ///     Sets the length in pixels of step tick marks
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public decimal? TickLen { get; set;} 

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public decimal? TickWidth { get; set;} 

        /// <summary>
        ///     Gets or sets the Transition.
        /// </summary>
        [JsonPropertyName(@"transition")]
        public Plotly.Blazor.LayoutLib.SliderLib.Transition Transition { get; set;} 

        /// <summary>
        ///     Determines whether or not the slider is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the slider.
        /// </summary>
        [JsonPropertyName(@"x")]
        public decimal? X { get; set;} 

        /// <summary>
        ///     Sets the slider&#39;s horizontal position anchor. This anchor binds the
        ///     <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c> of the
        ///     range selector.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public Plotly.Blazor.LayoutLib.SliderLib.XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the slider.
        /// </summary>
        [JsonPropertyName(@"y")]
        public decimal? Y { get; set;} 

        /// <summary>
        ///     Sets the slider&#39;s vertical position anchor This anchor binds the <c>y</c>
        ///     position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the range
        ///     selector.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public Plotly.Blazor.LayoutLib.SliderLib.YAnchorEnum? YAnchor { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Slider other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Slider other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Active == other.Active ||
                    Active != null &&
                    Active.Equals(other.Active)
                ) && 
                (
                    ActiveBgColor == other.ActiveBgColor ||
                    ActiveBgColor != null &&
                    ActiveBgColor.Equals(other.ActiveBgColor)
                ) && 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    BorderColor == other.BorderColor ||
                    BorderColor != null &&
                    BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    BorderWidth == other.BorderWidth ||
                    BorderWidth != null &&
                    BorderWidth.Equals(other.BorderWidth)
                ) && 
                (
                    CurrentValue == other.CurrentValue ||
                    CurrentValue != null &&
                    CurrentValue.Equals(other.CurrentValue)
                ) && 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Len == other.Len ||
                    Len != null &&
                    Len.Equals(other.Len)
                ) && 
                (
                    LenMode == other.LenMode ||
                    LenMode != null &&
                    LenMode.Equals(other.LenMode)
                ) && 
                (
                    MinorTickLen == other.MinorTickLen ||
                    MinorTickLen != null &&
                    MinorTickLen.Equals(other.MinorTickLen)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Pad == other.Pad ||
                    Pad != null &&
                    Pad.Equals(other.Pad)
                ) && 
                (
                    Equals(Steps, other.Steps) ||
                    Steps != null && other.Steps != null &&
                    Steps.SequenceEqual(other.Steps)
                ) &&
                (
                    TemplateItemName == other.TemplateItemName ||
                    TemplateItemName != null &&
                    TemplateItemName.Equals(other.TemplateItemName)
                ) && 
                (
                    TickColor == other.TickColor ||
                    TickColor != null &&
                    TickColor.Equals(other.TickColor)
                ) && 
                (
                    TickLen == other.TickLen ||
                    TickLen != null &&
                    TickLen.Equals(other.TickLen)
                ) && 
                (
                    TickWidth == other.TickWidth ||
                    TickWidth != null &&
                    TickWidth.Equals(other.TickWidth)
                ) && 
                (
                    Transition == other.Transition ||
                    Transition != null &&
                    Transition.Equals(other.Transition)
                ) && 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    X == other.X ||
                    X != null &&
                    X.Equals(other.X)
                ) && 
                (
                    XAnchor == other.XAnchor ||
                    XAnchor != null &&
                    XAnchor.Equals(other.XAnchor)
                ) && 
                (
                    Y == other.Y ||
                    Y != null &&
                    Y.Equals(other.Y)
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
                if (Active != null) hashCode = hashCode * 59 + Active.GetHashCode();
                if (ActiveBgColor != null) hashCode = hashCode * 59 + ActiveBgColor.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (BorderColor != null) hashCode = hashCode * 59 + BorderColor.GetHashCode();
                if (BorderWidth != null) hashCode = hashCode * 59 + BorderWidth.GetHashCode();
                if (CurrentValue != null) hashCode = hashCode * 59 + CurrentValue.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Len != null) hashCode = hashCode * 59 + Len.GetHashCode();
                if (LenMode != null) hashCode = hashCode * 59 + LenMode.GetHashCode();
                if (MinorTickLen != null) hashCode = hashCode * 59 + MinorTickLen.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (Pad != null) hashCode = hashCode * 59 + Pad.GetHashCode();
                if (Steps != null) hashCode = hashCode * 59 + Steps.GetHashCode();
                if (TemplateItemName != null) hashCode = hashCode * 59 + TemplateItemName.GetHashCode();
                if (TickColor != null) hashCode = hashCode * 59 + TickColor.GetHashCode();
                if (TickLen != null) hashCode = hashCode * 59 + TickLen.GetHashCode();
                if (TickWidth != null) hashCode = hashCode * 59 + TickWidth.GetHashCode();
                if (Transition != null) hashCode = hashCode * 59 + Transition.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (XAnchor != null) hashCode = hashCode * 59 + XAnchor.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (YAnchor != null) hashCode = hashCode * 59 + YAnchor.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Slider and the right Slider.
        /// </summary>
        /// <param name="left">Left Slider.</param>
        /// <param name="right">Right Slider.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Slider left, Slider right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Slider and the right Slider.
        /// </summary>
        /// <param name="left">Left Slider.</param>
        /// <param name="right">Right Slider.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Slider left, Slider right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Slider</returns>
        public Slider DeepClone()
        {
            return this.Copy();
        }
    }
}