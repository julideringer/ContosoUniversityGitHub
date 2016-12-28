using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }//La propiedad ID se convertira en la llave primaria de la columna de nuestra base de datos
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        //Enrollments es una navigation property que junta otras entidades que tienen relación.
        //Por lo tanto la propiedad enrollments de una entidad estudiante tendrá todas las enrollment entidades que estan relacionadas con la 
        //entidad estudiante.
     }
}
