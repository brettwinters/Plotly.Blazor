/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ContourCarpetLib.ColorBarLib
{
    /// <summary>
    ///     Sets this color bar&#39;s horizontal position anchor. This anchor binds
    ///     the <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c>
    ///     of the color bar. Defaults to <c>left</c> when <c>orientation</c> is <c>v</c>
    ///     and <c>center</c> when <c>orientation</c> is <c>h</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}