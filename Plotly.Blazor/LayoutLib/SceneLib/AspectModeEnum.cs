/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.SceneLib
{
    /// <summary>
    ///     If <c>cube</c>, this scene&#39;s axes are drawn as a cube, regardless of
    ///     the axes&#39; ranges. If <c>data</c>, this scene&#39;s axes are drawn in
    ///     proportion with the axes&#39; ranges. If <c>manual</c>, this scene&#39;s
    ///     axes are drawn in proportion with the input of <c>aspectratio</c> (the default
    ///     behavior if <c>aspectratio</c> is provided). If <c>auto</c>, this scene&#39;s
    ///     axes are drawn using the results of <c>data</c> except when one axis is
    ///     more than four times the size of the two others, where in that case the
    ///     results of <c>cube</c> are used.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum AspectModeEnum
    {
        [EnumMember(Value=@"auto")]
        Auto = 0,
        [EnumMember(Value=@"cube")]
        Cube,
        [EnumMember(Value=@"data")]
        Data,
        [EnumMember(Value=@"manual")]
        Manual
    }
}