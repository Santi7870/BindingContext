using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingContext.Models
{
    public class EstudianteUDLA
    {

        public EstudianteUDLA() {

            ID = 0;
            Nombre = "";
            Carrera = "";
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }


    }
}
