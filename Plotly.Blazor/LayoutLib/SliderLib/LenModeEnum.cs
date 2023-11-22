/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.SliderLib
{
    /// <summary>
    ///     Determines whether this slider length is set in units of plot <c>fraction</c>
    ///     or in *pixels. Use <c>len</c> to set the value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum LenModeEnum
    {
        [EnumMember(Value=@"fraction")]
        Fraction = 0,
        [EnumMember(Value=@"pixels")]
        Pixels
    }
}