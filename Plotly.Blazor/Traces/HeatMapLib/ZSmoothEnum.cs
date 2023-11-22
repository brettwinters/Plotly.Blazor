/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.HeatMapLib
{
    /// <summary>
    ///     Picks a smoothing algorithm use to smooth <c>z</c> data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ZSmoothEnum
    {
        [EnumMember(Value=@"false")]
        False = 0,
        [EnumMember(Value=@"fast")]
        Fast,
        [EnumMember(Value=@"best")]
        Best
    }
}