/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.WaterfallLib
{
    /// <summary>
    ///     Specifies the location of the <c>text</c>. <c>inside</c> positions <c>text</c>
    ///     inside, next to the bar end (rotated and scaled if needed). <c>outside</c>
    ///     positions <c>text</c> outside, next to the bar end (scaled if needed), unless
    ///     there is another bar stacked on this one, then the text gets pushed inside.
    ///     <c>auto</c> tries to position <c>text</c> inside the bar, but if the bar
    ///     is too small and no bar is stacked on this one the text is moved outside.
    ///     If <c>none</c>, no text appears.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TextPositionEnum
    {
        [EnumMember(Value=@"auto")]
        Auto = 0,
        [EnumMember(Value=@"inside")]
        Inside,
        [EnumMember(Value=@"outside")]
        Outside,
        [EnumMember(Value=@"none")]
        None
    }
}