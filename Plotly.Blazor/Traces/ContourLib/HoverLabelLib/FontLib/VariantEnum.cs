/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ContourLib.HoverLabelLib.FontLib
{
    /// <summary>
    ///     Sets the variant of the font.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum VariantEnum
    {
        [EnumMember(Value=@"normal")]
        Normal = 0,
        [EnumMember(Value=@"small-caps")]
        SmallCaps,
        [EnumMember(Value=@"all-small-caps")]
        AllSmallCaps,
        [EnumMember(Value=@"all-petite-caps")]
        AllPetiteCaps,
        [EnumMember(Value=@"petite-caps")]
        PetiteCaps,
        [EnumMember(Value=@"unicase")]
        UniCase
    }
}