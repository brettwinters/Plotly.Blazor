/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ViolinLib
{
    /// <summary>
    ///     Do the hover effects highlight individual violins or sample points or the
    ///     kernel density estimate or any combination of them?
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverOnFlag
    {
        [EnumMember(Value=@"violins")]
        Violins = 1,
        [EnumMember(Value=@"points")]
        Points = 2,
        [EnumMember(Value=@"kde")]
        Kde = 4,
        [EnumMember(Value=@"all")]
        All = Violins | Points | Kde
    }
}