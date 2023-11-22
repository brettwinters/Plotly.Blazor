/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.PolarLib.RadialAxisLib
{
    /// <summary>
    ///     Determines whether or not the range of this axis is computed in relation
    ///     to the input data. See <c>rangemode</c> for more info. If <c>range</c> is
    ///     provided and it has a value for both the lower and upper bound, <c>autorange</c>
    ///     is set to <c>false</c>. Using <c>min</c> applies autorange only to set the
    ///     minimum. Using <c>max</c> applies autorange only to set the maximum. Using
    ///     &#39;min reversed&#39; applies autorange only to set the minimum on a reversed
    ///     axis. Using &#39;max reversed&#39; applies autorange only to set the maximum
    ///     on a reversed axis. Using <c>reversed</c> applies autorange on both ends
    ///     and reverses the axis direction.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum AutoRangeEnum
    {
        [EnumMember(Value=@"true")]
        True = 0,
        [EnumMember(Value=@"False")]
        False,
        [EnumMember(Value=@"reversed")]
        Reversed,
        [EnumMember(Value=@"min reversed")]
        MinReversed,
        [EnumMember(Value=@"max reversed")]
        MaxReversed,
        [EnumMember(Value=@"min")]
        Min,
        [EnumMember(Value=@"max")]
        Max
    }
}