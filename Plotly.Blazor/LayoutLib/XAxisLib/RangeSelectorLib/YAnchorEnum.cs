/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.XAxisLib.RangeSelectorLib
{
    /// <summary>
    ///     Sets the range selector&#39;s vertical position anchor This anchor binds
    ///     the <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c>
    ///     of the range selector.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value=@"bottom")]
        Bottom = 0,
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"middle")]
        Middle
    }
}