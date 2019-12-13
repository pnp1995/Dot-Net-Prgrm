using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
   public class ResetPasswordModel
   {
        //[Key("UserModel")]
        //[Emailid]
       
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
   }
}
