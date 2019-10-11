// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FacadeResto.cs" company="Bridgelabz">
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
    /// FacadeResto is a class.
    /// </summary>
    class FacadeResto
    {
        /// <summary>
        /// The biryani
        /// </summary>
        private IBiryani biryani;
        private IMeals meals;
        /// <summary>
        /// Initializes a new instance of the <see cref="FacadeResto"/> class.
        /// </summary>
        public FacadeResto()
        {
            biryani = new BiryaniOrder();
            meals = new MealsOrder();

        }
        /// <summary>
        /// Orders the veg biryani.
        /// </summary>
        public void OrderVegBiryani()
        {
            biryani.GetVegBiryani();
        }
        /// <summary>
        /// Orders the non veg biryani.
        /// </summary>
        public void OrderNonVegBiryani()
        {
        biryani.GetNonVegBiryani();
        }
        public void OrderVegMeals()
        {
            meals.VegMeals();
        }
        public void OrderNonVegMeals()
        {
            meals.NonVegMeals();
        }
    }
}
