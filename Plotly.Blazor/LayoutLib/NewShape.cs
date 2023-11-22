/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The NewShape class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class NewShape : IEquatable<NewShape>
    {
        /// <summary>
        ///     When <c>dragmode</c> is set to <c>drawrect</c>, <c>drawline</c> or <c>drawcircle</c>
        ///     this limits the drag to be horizontal, vertical or diagonal. Using <c>diagonal</c>
        ///     there is no limit e.g. in drawing lines in any direction. <c>ortho</c> limits
        ///     the draw to be either horizontal or vertical. <c>horizontal</c> allows horizontal
        ///     extend. <c>vertical</c> allows vertical extend.
        /// </summary>
        [JsonPropertyName(@"drawdirection")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.DrawDirectionEnum? DrawDirection { get; set;} 

        /// <summary>
        ///     Sets the color filling new shapes&#39; interior. Please note that if using
        ///     a fillcolor with alpha greater than half, drag inside the active shape starts
        ///     moving the shape underneath, otherwise a new shape could be started over.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Determines the path&#39;s interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
        /// </summary>
        [JsonPropertyName(@"fillrule")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.FillRuleEnum? FillRule { get; set;} 

        /// <summary>
        ///     Gets or sets the Label.
        /// </summary>
        [JsonPropertyName(@"label")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.Label Label { get; set;} 

        /// <summary>
        ///     Specifies whether new shapes are drawn below or above traces.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.LayerEnum? Layer { get; set;} 

        /// <summary>
        ///     Sets the reference to a legend to show new shape in. References to these
        ///     legends are <c>legend</c>, <c>legend2</c>, <c>legend3</c>, etc. Settings
        ///     for these legends are set in the layout, under <c>layout.legend</c>, <c>layout.legend2</c>,
        ///     etc.
        /// </summary>
        [JsonPropertyName(@"legend")]
        public string Legend { get; set;} 

        /// <summary>
        ///     Sets the legend group for new shape. Traces and shapes part of the same
        ///     legend group hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

        /// <summary>
        ///     Gets or sets the LegendGroupTitle.
        /// </summary>
        [JsonPropertyName(@"legendgrouptitle")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.LegendGroupTitle LegendGroupTitle { get; set;} 

        /// <summary>
        ///     Sets the legend rank for new shape. Items and groups with smaller ranks
        ///     are presented on top/left side while with <c>reversed</c> <c>legend.traceorder</c>
        ///     they are on bottom/right side. The default legendrank is 1000, so that you
        ///     can use ranks less than 1000 to place certain items before all unranked
        ///     items, and ranks greater than 1000 to go after all unranked items.
        /// </summary>
        [JsonPropertyName(@"legendrank")]
        public decimal? LegendRank { get; set;} 

        /// <summary>
        ///     Sets the width (in px or fraction) of the legend for new shape.
        /// </summary>
        [JsonPropertyName(@"legendwidth")]
        public decimal? LegendWidth { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets new shape name. The name appears as the legend item.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Sets the opacity of new shapes.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Determines whether or not new shape is shown in the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Determines whether or not new shape is visible. If <c>legendonly</c>, the
        ///     shape is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.LayoutLib.NewShapeLib.VisibleEnum? Visible { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is NewShape other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] NewShape other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DrawDirection == other.DrawDirection ||
                    DrawDirection != null &&
                    DrawDirection.Equals(other.DrawDirection)
                ) && 
                (
                    FillColor == other.FillColor ||
                    FillColor != null &&
                    FillColor.Equals(other.FillColor)
                ) && 
                (
                    FillRule == other.FillRule ||
                    FillRule != null &&
                    FillRule.Equals(other.FillRule)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Layer == other.Layer ||
                    Layer != null &&
                    Layer.Equals(other.Layer)
                ) && 
                (
                    Legend == other.Legend ||
                    Legend != null &&
                    Legend.Equals(other.Legend)
                ) && 
                (
                    LegendGroup == other.LegendGroup ||
                    LegendGroup != null &&
                    LegendGroup.Equals(other.LegendGroup)
                ) && 
                (
                    LegendGroupTitle == other.LegendGroupTitle ||
                    LegendGroupTitle != null &&
                    LegendGroupTitle.Equals(other.LegendGroupTitle)
                ) && 
                (
                    LegendRank == other.LegendRank ||
                    LegendRank != null &&
                    LegendRank.Equals(other.LegendRank)
                ) && 
                (
                    LegendWidth == other.LegendWidth ||
                    LegendWidth != null &&
                    LegendWidth.Equals(other.LegendWidth)
                ) && 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    ShowLegend == other.ShowLegend ||
                    ShowLegend != null &&
                    ShowLegend.Equals(other.ShowLegend)
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
                if (DrawDirection != null) hashCode = hashCode * 59 + DrawDirection.GetHashCode();
                if (FillColor != null) hashCode = hashCode * 59 + FillColor.GetHashCode();
                if (FillRule != null) hashCode = hashCode * 59 + FillRule.GetHashCode();
                if (Label != null) hashCode = hashCode * 59 + Label.GetHashCode();
                if (Layer != null) hashCode = hashCode * 59 + Layer.GetHashCode();
                if (Legend != null) hashCode = hashCode * 59 + Legend.GetHashCode();
                if (LegendGroup != null) hashCode = hashCode * 59 + LegendGroup.GetHashCode();
                if (LegendGroupTitle != null) hashCode = hashCode * 59 + LegendGroupTitle.GetHashCode();
                if (LegendRank != null) hashCode = hashCode * 59 + LegendRank.GetHashCode();
                if (LegendWidth != null) hashCode = hashCode * 59 + LegendWidth.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (ShowLegend != null) hashCode = hashCode * 59 + ShowLegend.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left NewShape and the right NewShape.
        /// </summary>
        /// <param name="left">Left NewShape.</param>
        /// <param name="right">Right NewShape.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (NewShape left, NewShape right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left NewShape and the right NewShape.
        /// </summary>
        /// <param name="left">Left NewShape.</param>
        /// <param name="right">Right NewShape.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (NewShape left, NewShape right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>NewShape</returns>
        public NewShape DeepClone()
        {
            return this.Copy();
        }
    }
}