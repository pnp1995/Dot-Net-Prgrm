
namespace ObjectOrientedPrograms.InventaryDataMangement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// InventaryModel is class name.
    /// </summary>
    class InventaryModel
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        /// <summary>
        /// The weight/
        /// </summary>
        private double weight;
        /// <summary>
        /// The priceperkg/
        /// </summary>
        private double priceperkg;
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }
        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg { get; set; }
    }
}
 