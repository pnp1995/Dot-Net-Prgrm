using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
  public  class ForgetPasswordModel
    {
        /// <summary>
        /// Gets or sets the emailid.
        /// </summary>
        /// <value>
        /// The emailid.
        /// </value>
        public string Emailid { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }
    }
}
