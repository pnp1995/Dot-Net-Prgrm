// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IMeals.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.FacadeDesignPattern
{
    /// <summary>
    /// create a intewrface Imeals
    /// </summary>
    public interface IMeals
    {
        /// <summary>
        /// Vegs the meals.
        /// </summary>
        void VegMeals();
        void NonVegMeals();
    }
}
