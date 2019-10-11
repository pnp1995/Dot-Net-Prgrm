using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Design_Pattern.Reflection
{
    class Annotation
    {
        public object Validatior { get;  set; }
        public object Valid { get;  set; }
        public bool IsValid { get;  set; }

        public void AnnotationMain()
        {
            Employee employee = new Employee();
            employee.EmployeeName = "";
            var context = new ValidationContext(employee, null, null);
           // bool IsValid = Validatior.TryValidatObject(employee, null, null);
            Console.WriteLine(IsValid);
        }
    }
}
