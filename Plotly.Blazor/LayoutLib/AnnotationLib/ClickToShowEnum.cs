/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.AnnotationLib
{
    /// <summary>
    ///     Makes this annotation respond to clicks on the plot. If you click a data
    ///     point that exactly matches the <c>x</c> and <c>y</c> values of this annotation,
    ///     and it is hidden (visible: false), it will appear. In <c>onoff</c> mode,
    ///     you must click the same point again to make it disappear, so if you click
    ///     multiple points, you can show multiple annotations. In <c>onout</c> mode,
    ///     a click anywhere else in the plot (on another data point or not) will hide
    ///     this annotation. If you need to show/hide this annotation in response to
    ///     different <c>x</c> or <c>y</c> values, you can set <c>xclick</c> and/or
    ///     <c>yclick</c>. This is useful for example to label the side of a bar. To
    ///     label markers though, <c>standoff</c> is preferred over <c>xclick</c> and
    ///     <c>yclick</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ClickToShowEnum
    {
        [EnumMember(Value=@"false")]
        False = 0,
        [EnumMember(Value=@"onoff")]
        OnOff,
        [EnumMember(Value=@"onout")]
        OnOut
    }
}