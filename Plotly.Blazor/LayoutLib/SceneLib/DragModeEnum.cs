/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.SceneLib
{
    /// <summary>
    ///     Determines the mode of drag interactions for this scene.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum DragModeEnum
    {
        [EnumMember(Value=@"orbit")]
        Orbit,
        [EnumMember(Value=@"turntable")]
        Turntable,
        [EnumMember(Value=@"zoom")]
        Zoom,
        [EnumMember(Value=@"pan")]
        Pan,
        [EnumMember(Value=@"False")]
        False
    }
}