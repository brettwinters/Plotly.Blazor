/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.UpdateMenuLib
{
    /// <summary>
    ///     Determines whether the buttons are accessible via a dropdown menu or whether
    ///     the buttons are stacked horizontally or vertically
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"dropdown")]
        DropDown = 0,
        [EnumMember(Value=@"buttons")]
        Buttons
    }
}