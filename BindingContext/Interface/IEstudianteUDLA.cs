using BindingContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingContext.Interface
{
    internal interface IEstudianteUDLARepository
    {

        List<EstudianteUDLA> DevuelveListadoEstudianteUDLA();
        EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id);
        Boolean CrearEstudianteUDLA();
        Boolean ActualizarEstudianteUDLA(int Id, EstudianteUDLA estudiante);
        Boolean EliminarEstudianteUDLA(int id);
    }
}
