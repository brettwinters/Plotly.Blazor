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
    ///     The Image class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Image : IEquatable<Image>
    {
        /// <summary>
        ///     Specifies whether images are drawn below or above traces. When <c>xref</c>
        ///     and <c>yref</c> are both set to <c>paper</c>, image is drawn below the entire
        ///     plot area.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public Plotly.Blazor.LayoutLib.ImageLib.LayerEnum? Layer { get; set;} 

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
        ///     Sets the opacity of the image.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Sets the image container size horizontally. The image will be sized based
        ///     on the <c>position</c> value. When <c>xref</c> is set to <c>paper</c>, units
        ///     are sized relative to the plot width. When <c>xref</c> ends with &#39; domain&#39;,
        ///     units are sized relative to the axis width.
        /// </summary>
        [JsonPropertyName(@"sizex")]
        public decimal? SizeX { get; set;} 

        /// <summary>
        ///     Sets the image container size vertically. The image will be sized based
        ///     on the <c>position</c> value. When <c>yref</c> is set to <c>paper</c>, units
        ///     are sized relative to the plot height. When <c>yref</c> ends with &#39;
        ///     domain&#39;, units are sized relative to the axis height.
        /// </summary>
        [JsonPropertyName(@"sizey")]
        public decimal? SizeY { get; set;} 

        /// <summary>
        ///     Specifies which dimension of the image to constrain.
        /// </summary>
        [JsonPropertyName(@"sizing")]
        public Plotly.Blazor.LayoutLib.ImageLib.SizingEnum? Sizing { get; set;} 

        /// <summary>
        ///     Specifies the URL of the image to be used. The URL must be accessible from
        ///     the domain where the plot code is run, and can be either relative or absolute.
        /// </summary>
        [JsonPropertyName(@"source")]
        public string Source { get; set;} 

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
        ///     Determines whether or not this image is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the image&#39;s x position. When <c>xref</c> is set to <c>paper</c>,
        ///     units are sized relative to the plot height. See <c>xref</c> for more info
        /// </summary>
        [JsonPropertyName(@"x")]
        public object X { get; set;} 

        /// <summary>
        ///     Sets the anchor for the x position
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public Plotly.Blazor.LayoutLib.ImageLib.XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the images&#39;s x coordinate axis. If set to a x axis id (e.g. <c>x</c>
        ///     or <c>x2</c>), the <c>x</c> position refers to a x coordinate. If set to
        ///     <c>paper</c>, the <c>x</c> position refers to the distance from the left
        ///     of the plotting area in normalized coordinates where <c>0</c> (<c>1</c>)
        ///     corresponds to the left (right). If set to a x axis ID followed by <c>domain</c>
        ///     (separated by a space), the position behaves like for <c>paper</c>, but
        ///     refers to the distance in fractions of the domain length from the left of
        ///     the domain of that axis: e.g., &#39;x2 domain&#39; refers to the domain
        ///     of the second x  axis and a x position of 0.5 refers to the point between
        ///     the left and the right of the domain of the second x axis.
        /// </summary>
        [JsonPropertyName(@"xref")]
        public string XRef { get; set;} 

        /// <summary>
        ///     Sets the image&#39;s y position. When <c>yref</c> is set to <c>paper</c>,
        ///     units are sized relative to the plot height. See <c>yref</c> for more info
        /// </summary>
        [JsonPropertyName(@"y")]
        public object Y { get; set;} 

        /// <summary>
        ///     Sets the anchor for the y position.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public Plotly.Blazor.LayoutLib.ImageLib.YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Sets the images&#39;s y coordinate axis. If set to a y axis id (e.g. <c>y</c>
        ///     or <c>y2</c>), the <c>y</c> position refers to a y coordinate. If set to
        ///     <c>paper</c>, the <c>y</c> position refers to the distance from the bottom
        ///     of the plotting area in normalized coordinates where <c>0</c> (<c>1</c>)
        ///     corresponds to the bottom (top). If set to a y axis ID followed by <c>domain</c>
        ///     (separated by a space), the position behaves like for <c>paper</c>, but
        ///     refers to the distance in fractions of the domain length from the bottom
        ///     of the domain of that axis: e.g., &#39;y2 domain&#39; refers to the domain
        ///     of the second y  axis and a y position of 0.5 refers to the point between
        ///     the bottom and the top of the domain of the second y axis.
        /// </summary>
        [JsonPropertyName(@"yref")]
        public string YRef { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Image other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Image other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Layer == other.Layer ||
                    Layer != null &&
                    Layer.Equals(other.Layer)
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
                    SizeX == other.SizeX ||
                    SizeX != null &&
                    SizeX.Equals(other.SizeX)
                ) && 
                (
                    SizeY == other.SizeY ||
                    SizeY != null &&
                    SizeY.Equals(other.SizeY)
                ) && 
                (
                    Sizing == other.Sizing ||
                    Sizing != null &&
                    Sizing.Equals(other.Sizing)
                ) && 
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
                ) && 
                (
                    TemplateItemName == other.TemplateItemName ||
                    TemplateItemName != null &&
                    TemplateItemName.Equals(other.TemplateItemName)
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
                    XRef == other.XRef ||
                    XRef != null &&
                    XRef.Equals(other.XRef)
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
                ) && 
                (
                    YRef == other.YRef ||
                    YRef != null &&
                    YRef.Equals(other.YRef)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Layer != null) hashCode = hashCode * 59 + Layer.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (SizeX != null) hashCode = hashCode * 59 + SizeX.GetHashCode();
                if (SizeY != null) hashCode = hashCode * 59 + SizeY.GetHashCode();
                if (Sizing != null) hashCode = hashCode * 59 + Sizing.GetHashCode();
                if (Source != null) hashCode = hashCode * 59 + Source.GetHashCode();
                if (TemplateItemName != null) hashCode = hashCode * 59 + TemplateItemName.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (XAnchor != null) hashCode = hashCode * 59 + XAnchor.GetHashCode();
                if (XRef != null) hashCode = hashCode * 59 + XRef.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (YAnchor != null) hashCode = hashCode * 59 + YAnchor.GetHashCode();
                if (YRef != null) hashCode = hashCode * 59 + YRef.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Image and the right Image.
        /// </summary>
        /// <param name="left">Left Image.</param>
        /// <param name="right">Right Image.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Image left, Image right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Image and the right Image.
        /// </summary>
        /// <param name="left">Left Image.</param>
        /// <param name="right">Right Image.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Image left, Image right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Image</returns>
        public Image DeepClone()
        {
            return this.Copy();
        }
    }
}