﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantity.cs" company="QuantityTypes">
//   Copyright (c) 2014 QuantityTypes contributors
// </copyright>
// <summary>
//   Defines a quantity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityTypes
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Defines a quantity.
    /// </summary>
    public interface IQuantity : IComparable, IFormattable, IXmlSerializable
    {
        /// <summary>
        /// Gets the amount of quantity in the base unit.
        /// </summary>
        /// <value>The value.</value>
        double Value { get; }

        /// <summary>
        /// Converts the quantity to the specified unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>The amount of the specified unit.</returns>
        double ConvertTo(IQuantity unit);

        /// <summary>
        /// Multiplies by the specified number.
        /// </summary>
        /// <param name="x">The number.</param>
        /// <returns>The new quantity.</returns>
        IQuantity MultiplyBy(double x);

        /// <summary>
        /// Adds the specified quantity.
        /// </summary>
        /// <param name="x">The quantity to add.</param>
        /// <returns>The sum.</returns>
        IQuantity Add(IQuantity x);
    }
}