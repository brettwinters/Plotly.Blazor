/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ParCatsLib
{
    /// <summary>
    ///     Sets the drag interaction mode for categories and dimensions. If <c>perpendicular</c>,
    ///     the categories can only move along a line perpendicular to the paths. If
    ///     <c>freeform</c>, the categories can freely move on the plane. If <c>fixed</c>,
    ///     the categories and dimensions are stationary.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ArrangementEnum
    {
        [EnumMember(Value=@"perpendicular")]
        Perpendicular = 0,
        [EnumMember(Value=@"freeform")]
        FreeForm,
        [EnumMember(Value=@"fixed")]
        Fixed
    }
}