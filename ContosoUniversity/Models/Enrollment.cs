using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
            //La propiedad grado es un enum. El signo de pregunta que viene abajo en Grade indica
            //que la propiedad de grado es nullable. Un grado que es null es diferente de cero.
            //Null significa que no se sabe o no ha sido asignado todavia.
    }
         public class Enrollment
         {
             public int EnrollmentID { get; set; }//La propiedad de Enrollmentid es una llave primaria.
             public int CourseID { get; set; }//La propiedad CourseID es una llave de fuera .
             public int StudentID { get; set; }//La propiedad StudenID es una llave de fuera que corresponde con la
        //propiedad de navegación de Student.
             public Grade? Grade { get; set; }

             public virtual Course Course { get; set; }
             public virtual Student Student { get; set; }
        //La navigation properties esta normalmente definida como virtual por eso  tiene la funcionalidad Entity Framework como un lazy loading
         }
}
