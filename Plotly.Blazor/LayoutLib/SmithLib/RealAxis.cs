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

namespace Plotly.Blazor.LayoutLib.SmithLib
{
    /// <summary>
    ///     The RealAxis class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class RealAxis : IEquatable<RealAxis>
    {
        /// <summary>
        ///     Sets default for all colors associated with this axis all at once: line,
        ///     font, tick, and grid colors. Grid color is lightened by blending this with
        ///     the plot background Individual pieces can override this.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the color of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object GridColor { get; set;} 

        /// <summary>
        ///     Sets the dash style of lines. Set to a dash type string (<c>solid</c>, <c>dot</c>,
        ///     <c>dash</c>, <c>longdash</c>, <c>dashdot</c>, or <c>longdashdot</c>) or
        ///     a dash length list in px (eg <c>5px,10px,2px,2px</c>).
        /// </summary>
        [JsonPropertyName(@"griddash")]
        public string GridDash { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public decimal? GridWidth { get; set;} 

        /// <summary>
        ///     Sets the hover text formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format.
        ///     And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format.
        ///     We add two items to d3&#39;s date formatter: <c>%h</c> for half of the year
        ///     as a decimal number as well as <c>%{n}f</c> for fractional seconds with
        ///     n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with tickformat
        ///     <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"hoverformat")]
        public string HoverFormat { get; set;} 

        /// <summary>
        ///     Replacement text for specific tick or hover labels. For example using {US:
        ///     <c>USA</c>, CA: <c>Canada</c>} changes US to USA and CA to Canada. The labels
        ///     we would have shown must match the keys exactly, after adding any tickprefix
        ///     or ticksuffix. For negative numbers the minus sign symbol used (U+2212)
        ///     is wider than the regular ascii dash. That means you need to use −1 instead
        ///     of -1. labelalias can be used with any axis type, and both keys (if needed)
        ///     and values (if desired) can include html-like tags or MathJax.
        /// </summary>
        [JsonPropertyName(@"labelalias")]
        public object LabelAlias { get; set;} 

        /// <summary>
        ///     Sets the layer on which this axis is displayed. If &#39;above traces&#39;,
        ///     this axis is displayed above all the subplot&#39;s traces If &#39;below
        ///     traces&#39;, this axis is displayed below all the subplot&#39;s traces,
        ///     but above the grid lines. Useful when used together with scatter-like traces
        ///     with <c>cliponaxis</c> set to <c>false</c> to show markers and/or text nodes
        ///     above this axis.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public Plotly.Blazor.LayoutLib.SmithLib.RealAxisLib.LayerEnum? Layer { get; set;} 

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"linecolor")]
        public object LineColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the axis line.
        /// </summary>
        [JsonPropertyName(@"linewidth")]
        public decimal? LineWidth { get; set;} 

        /// <summary>
        ///     Determines whether or not grid lines are drawn. If <c>true</c>, the grid
        ///     lines are drawn at every tick mark.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set;} 

        /// <summary>
        ///     Determines whether or not a line bounding this axis is drawn.
        /// </summary>
        [JsonPropertyName(@"showline")]
        public bool? ShowLine { get; set;} 

        /// <summary>
        ///     Determines whether or not the tick labels are drawn.
        /// </summary>
        [JsonPropertyName(@"showticklabels")]
        public bool? ShowTickLabels { get; set;} 

        /// <summary>
        ///     If <c>all</c>, all tick labels are displayed with a prefix. If <c>first</c>,
        ///     only the first tick is displayed with a prefix. If <c>last</c>, only the
        ///     last tick is displayed with a suffix. If <c>none</c>, tick prefixes are
        ///     hidden.
        /// </summary>
        [JsonPropertyName(@"showtickprefix")]
        public Plotly.Blazor.LayoutLib.SmithLib.RealAxisLib.ShowTickPrefixEnum? ShowTickPrefix { get; set;} 

        /// <summary>
        ///     Same as <c>showtickprefix</c> but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public Plotly.Blazor.LayoutLib.SmithLib.RealAxisLib.ShowTickSuffixEnum? ShowTickSuffix { get; set;} 

        /// <summary>
        ///     Determines on which side of real axis line the tick and tick labels appear.
        /// </summary>
        [JsonPropertyName(@"side")]
        public Plotly.Blazor.LayoutLib.SmithLib.RealAxisLib.SideEnum? Side { get; set;} 

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the horizontal. For example,
        ///     a <c>tickangle</c> of -90 draws the tick labels vertically.
        /// </summary>
        [JsonPropertyName(@"tickangle")]
        public decimal? TickAngle { get; set;} 

        /// <summary>
        ///     Sets the tick color.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set;} 

        /// <summary>
        ///     Sets the tick font.
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public Plotly.Blazor.LayoutLib.SmithLib.RealAxisLib.TickFont TickFont { get; set;} 

        /// <summary>
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format.
        ///     And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format.
        ///     We add two items to d3&#39;s date formatter: <c>%h</c> for half of the year
        ///     as a decimal number as well as <c>%{n}f</c> for fractional seconds with
        ///     n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with tickformat
        ///     <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string TickFormat { get; set;} 

        /// <summary>
        ///     Sets the tick length (in px).
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public decimal? TickLen { get; set;} 

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string TickPrefix { get; set;} 

        /// <summary>
        ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
        ///     not drawn. If <c>top</c> (<c>bottom</c>), this axis&#39; are drawn above
        ///     (below) the axis line.
        /// </summary>
        [JsonPropertyName(@"ticks")]
        public Plotly.Blazor.LayoutLib.SmithLib.RealAxisLib.TicksEnum? Ticks { get; set;} 

        /// <summary>
        ///     Sets a tick label suffix.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string TickSuffix { get; set;} 

        /// <summary>
        ///     Sets the values at which ticks on this axis appear.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public IList<object> TickVals { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>tickvals</c>.
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string TickValsSrc { get; set;} 

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public decimal? TickWidth { get; set;} 

        /// <summary>
        ///     A single toggle to hide the axis while preserving interaction like dragging.
        ///     Default is true when a cheater plot is present on the axis, otherwise false
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is RealAxis other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] RealAxis other)
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
                    GridColor == other.GridColor ||
                    GridColor != null &&
                    GridColor.Equals(other.GridColor)
                ) && 
                (
                    GridDash == other.GridDash ||
                    GridDash != null &&
                    GridDash.Equals(other.GridDash)
                ) && 
                (
                    GridWidth == other.GridWidth ||
                    GridWidth != null &&
                    GridWidth.Equals(other.GridWidth)
                ) && 
                (
                    HoverFormat == other.HoverFormat ||
                    HoverFormat != null &&
                    HoverFormat.Equals(other.HoverFormat)
                ) && 
                (
                    LabelAlias == other.LabelAlias ||
                    LabelAlias != null &&
                    LabelAlias.Equals(other.LabelAlias)
                ) && 
                (
                    Layer == other.Layer ||
                    Layer != null &&
                    Layer.Equals(other.Layer)
                ) && 
                (
                    LineColor == other.LineColor ||
                    LineColor != null &&
                    LineColor.Equals(other.LineColor)
                ) && 
                (
                    LineWidth == other.LineWidth ||
                    LineWidth != null &&
                    LineWidth.Equals(other.LineWidth)
                ) && 
                (
                    ShowGrid == other.ShowGrid ||
                    ShowGrid != null &&
                    ShowGrid.Equals(other.ShowGrid)
                ) && 
                (
                    ShowLine == other.ShowLine ||
                    ShowLine != null &&
                    ShowLine.Equals(other.ShowLine)
                ) && 
                (
                    ShowTickLabels == other.ShowTickLabels ||
                    ShowTickLabels != null &&
                    ShowTickLabels.Equals(other.ShowTickLabels)
                ) && 
                (
                    ShowTickPrefix == other.ShowTickPrefix ||
                    ShowTickPrefix != null &&
                    ShowTickPrefix.Equals(other.ShowTickPrefix)
                ) && 
                (
                    ShowTickSuffix == other.ShowTickSuffix ||
                    ShowTickSuffix != null &&
                    ShowTickSuffix.Equals(other.ShowTickSuffix)
                ) && 
                (
                    Side == other.Side ||
                    Side != null &&
                    Side.Equals(other.Side)
                ) && 
                (
                    TickAngle == other.TickAngle ||
                    TickAngle != null &&
                    TickAngle.Equals(other.TickAngle)
                ) && 
                (
                    TickColor == other.TickColor ||
                    TickColor != null &&
                    TickColor.Equals(other.TickColor)
                ) && 
                (
                    TickFont == other.TickFont ||
                    TickFont != null &&
                    TickFont.Equals(other.TickFont)
                ) && 
                (
                    TickFormat == other.TickFormat ||
                    TickFormat != null &&
                    TickFormat.Equals(other.TickFormat)
                ) && 
                (
                    TickLen == other.TickLen ||
                    TickLen != null &&
                    TickLen.Equals(other.TickLen)
                ) && 
                (
                    TickPrefix == other.TickPrefix ||
                    TickPrefix != null &&
                    TickPrefix.Equals(other.TickPrefix)
                ) && 
                (
                    Ticks == other.Ticks ||
                    Ticks != null &&
                    Ticks.Equals(other.Ticks)
                ) && 
                (
                    TickSuffix == other.TickSuffix ||
                    TickSuffix != null &&
                    TickSuffix.Equals(other.TickSuffix)
                ) && 
                (
                    Equals(TickVals, other.TickVals) ||
                    TickVals != null && other.TickVals != null &&
                    TickVals.SequenceEqual(other.TickVals)
                ) &&
                (
                    TickValsSrc == other.TickValsSrc ||
                    TickValsSrc != null &&
                    TickValsSrc.Equals(other.TickValsSrc)
                ) && 
                (
                    TickWidth == other.TickWidth ||
                    TickWidth != null &&
                    TickWidth.Equals(other.TickWidth)
                ) && 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (GridColor != null) hashCode = hashCode * 59 + GridColor.GetHashCode();
                if (GridDash != null) hashCode = hashCode * 59 + GridDash.GetHashCode();
                if (GridWidth != null) hashCode = hashCode * 59 + GridWidth.GetHashCode();
                if (HoverFormat != null) hashCode = hashCode * 59 + HoverFormat.GetHashCode();
                if (LabelAlias != null) hashCode = hashCode * 59 + LabelAlias.GetHashCode();
                if (Layer != null) hashCode = hashCode * 59 + Layer.GetHashCode();
                if (LineColor != null) hashCode = hashCode * 59 + LineColor.GetHashCode();
                if (LineWidth != null) hashCode = hashCode * 59 + LineWidth.GetHashCode();
                if (ShowGrid != null) hashCode = hashCode * 59 + ShowGrid.GetHashCode();
                if (ShowLine != null) hashCode = hashCode * 59 + ShowLine.GetHashCode();
                if (ShowTickLabels != null) hashCode = hashCode * 59 + ShowTickLabels.GetHashCode();
                if (ShowTickPrefix != null) hashCode = hashCode * 59 + ShowTickPrefix.GetHashCode();
                if (ShowTickSuffix != null) hashCode = hashCode * 59 + ShowTickSuffix.GetHashCode();
                if (Side != null) hashCode = hashCode * 59 + Side.GetHashCode();
                if (TickAngle != null) hashCode = hashCode * 59 + TickAngle.GetHashCode();
                if (TickColor != null) hashCode = hashCode * 59 + TickColor.GetHashCode();
                if (TickFont != null) hashCode = hashCode * 59 + TickFont.GetHashCode();
                if (TickFormat != null) hashCode = hashCode * 59 + TickFormat.GetHashCode();
                if (TickLen != null) hashCode = hashCode * 59 + TickLen.GetHashCode();
                if (TickPrefix != null) hashCode = hashCode * 59 + TickPrefix.GetHashCode();
                if (Ticks != null) hashCode = hashCode * 59 + Ticks.GetHashCode();
                if (TickSuffix != null) hashCode = hashCode * 59 + TickSuffix.GetHashCode();
                if (TickVals != null) hashCode = hashCode * 59 + TickVals.GetHashCode();
                if (TickValsSrc != null) hashCode = hashCode * 59 + TickValsSrc.GetHashCode();
                if (TickWidth != null) hashCode = hashCode * 59 + TickWidth.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left RealAxis and the right RealAxis.
        /// </summary>
        /// <param name="left">Left RealAxis.</param>
        /// <param name="right">Right RealAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (RealAxis left, RealAxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left RealAxis and the right RealAxis.
        /// </summary>
        /// <param name="left">Left RealAxis.</param>
        /// <param name="right">Right RealAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (RealAxis left, RealAxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>RealAxis</returns>
        public RealAxis DeepClone()
        {
            return this.Copy();
        }
    }
}