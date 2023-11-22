/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Ternary class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class Ternary : IEquatable<Ternary>
    {
        /// <summary>
        ///     Gets or sets the AAxis.
        /// </summary>
        [JsonPropertyName(@"aaxis")]
        public Plotly.Blazor.LayoutLib.TernaryLib.AAxis AAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the BAxis.
        /// </summary>
        [JsonPropertyName(@"baxis")]
        public Plotly.Blazor.LayoutLib.TernaryLib.BAxis BAxis { get; set;} 

        /// <summary>
        ///     Set the background color of the subplot
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Gets or sets the CAxis.
        /// </summary>
        [JsonPropertyName(@"caxis")]
        public Plotly.Blazor.LayoutLib.TernaryLib.CAxis CAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Plotly.Blazor.LayoutLib.TernaryLib.Domain Domain { get; set;} 

        /// <summary>
        ///     The number each triplet should sum to, and the maximum range of each axis
        /// </summary>
        [JsonPropertyName(@"sum")]
        public decimal? Sum { get; set;} 

        /// <summary>
        ///     Controls persistence of user-driven changes in axis <c>min</c> and <c>title</c>,
        ///     if not overridden in the individual axes. Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Ternary other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Ternary other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AAxis == other.AAxis ||
                    AAxis != null &&
                    AAxis.Equals(other.AAxis)
                ) && 
                (
                    BAxis == other.BAxis ||
                    BAxis != null &&
                    BAxis.Equals(other.BAxis)
                ) && 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    CAxis == other.CAxis ||
                    CAxis != null &&
                    CAxis.Equals(other.CAxis)
                ) && 
                (
                    Domain == other.Domain ||
                    Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    Sum == other.Sum ||
                    Sum != null &&
                    Sum.Equals(other.Sum)
                ) && 
                (
                    UiRevision == other.UiRevision ||
                    UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (AAxis != null) hashCode = hashCode * 59 + AAxis.GetHashCode();
                if (BAxis != null) hashCode = hashCode * 59 + BAxis.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (CAxis != null) hashCode = hashCode * 59 + CAxis.GetHashCode();
                if (Domain != null) hashCode = hashCode * 59 + Domain.GetHashCode();
                if (Sum != null) hashCode = hashCode * 59 + Sum.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Ternary and the right Ternary.
        /// </summary>
        /// <param name="left">Left Ternary.</param>
        /// <param name="right">Right Ternary.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Ternary left, Ternary right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Ternary and the right Ternary.
        /// </summary>
        /// <param name="left">Left Ternary.</param>
        /// <param name="right">Right Ternary.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Ternary left, Ternary right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Ternary</returns>
        public Ternary DeepClone()
        {
            return this.Copy();
        }
    }
}