/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.ConfigLib
{
    /// <summary>
    ///     Determines whether mouse wheel or two-finger scroll zooms is enable. Turned
    ///     on by default for gl3d, geo and mapbox subplots (as these subplot types
    ///     do not have zoombox via pan), but turned off by default for cartesian subplots.
    ///     Set <c>scrollZoom</c> to <c>false</c> to disable scrolling for all subplots.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum ScrollZoomFlag
    {
        [EnumMember(Value=@"True")]
        True = 1,
        [EnumMember(Value=@"False")]
        False = 2,
        [EnumMember(Value=@"cartesian")]
        Cartesian = 4,
        [EnumMember(Value=@"gl3d")]
        Gl3D = 8,
        [EnumMember(Value=@"geo")]
        Geo = 16,
        [EnumMember(Value=@"mapbox")]
        MapBox = 32
    }
}