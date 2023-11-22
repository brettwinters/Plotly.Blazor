/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterGeoLib.MarkerLib
{
    /// <summary>
    ///     Sets the reference for marker angle. With <c>previous</c>, angle 0 points
    ///     along the line from the previous point to this one. With <c>up</c>, angle
    ///     0 points toward the top of the screen. With <c>north</c>, angle 0 points
    ///     north based on the current map projection.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum AngleRefEnum
    {
        [EnumMember(Value=@"up")]
        Up = 0,
        [EnumMember(Value=@"previous")]
        Previous,
        [EnumMember(Value=@"north")]
        North
    }
}