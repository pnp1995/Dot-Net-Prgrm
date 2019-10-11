// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IBiryani.cs" company="Bridgelabz">
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
    /// IBiryani is a class
    /// </summary>
    public interface IBiryani
    {
        /// <summary>
        /// Gets the veg biryani.
        /// </summary>
        void GetVegBiryani();
        void GetNonVegBiryani();
    }
}
