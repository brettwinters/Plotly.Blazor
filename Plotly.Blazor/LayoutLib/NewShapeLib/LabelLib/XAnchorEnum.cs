/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.NewShapeLib.LabelLib
{
    /// <summary>
    ///     Sets the label&#39;s horizontal position anchor This anchor binds the specified
    ///     <c>textposition</c> to the <c>left</c>, <c>center</c> or <c>right</c> of
    ///     the label text. For example, if <c>textposition</c> is set to &#39;top right&#39;
    ///     and <c>xanchor</c> to <c>right</c> then the right-most portion of the label
    ///     text lines up with the right-most edge of the new shape.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"auto")]
        Auto = 0,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}