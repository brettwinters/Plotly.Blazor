/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.OhlcLib
{
    /// <summary>
    ///     The Decreasing class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class Decreasing : IEquatable<Decreasing>
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.OhlcLib.DecreasingLib.Line Line { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Decreasing other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Decreasing other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Decreasing and the right Decreasing.
        /// </summary>
        /// <param name="left">Left Decreasing.</param>
        /// <param name="right">Right Decreasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Decreasing left, Decreasing right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Decreasing and the right Decreasing.
        /// </summary>
        /// <param name="left">Left Decreasing.</param>
        /// <param name="right">Right Decreasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Decreasing left, Decreasing right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Decreasing</returns>
        public Decreasing DeepClone()
        {
            return this.Copy();
        }
    }
}