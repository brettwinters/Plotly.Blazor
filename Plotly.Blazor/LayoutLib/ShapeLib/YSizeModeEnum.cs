/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.ShapeLib
{
    /// <summary>
    ///     Sets the shapes&#39;s sizing mode along the y axis. If set to <c>scaled</c>,
    ///     <c>y0</c>, <c>y1</c> and y coordinates within <c>path</c> refer to data
    ///     values on the y axis or a fraction of the plot area&#39;s height (<c>yref</c>
    ///     set to <c>paper</c>). If set to <c>pixel</c>, <c>yanchor</c> specifies the
    ///     y position in terms of data or plot fraction but <c>y0</c>, <c>y1</c> and
    ///     y coordinates within <c>path</c> are pixels relative to <c>yanchor</c>.
    ///     This way, the shape can have a fixed height while maintaining a position
    ///     relative to data or plot fraction.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YSizeModeEnum
    {
        [EnumMember(Value=@"scaled")]
        Scaled = 0,
        [EnumMember(Value=@"pixel")]
        Pixel
    }
}