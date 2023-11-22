/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.AnimationLib
{
    /// <summary>
    ///     Describes how a new animate call interacts with currently-running animations.
    ///     If <c>immediate</c>, current animations are interrupted and the new animation
    ///     is started. If <c>next</c>, the current frame is allowed to complete, after
    ///     which the new animation is started. If <c>afterall</c> all existing frames
    ///     are animated to completion before the new animation is started.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeEnum
    {
        [EnumMember(Value=@"afterall")]
        AfterAll = 0,
        [EnumMember(Value=@"immediate")]
        Immediate,
        [EnumMember(Value=@"next")]
        Next
    }
}