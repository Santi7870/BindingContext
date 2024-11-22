using BindingContext.Interface;
using BindingContext.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingContext.Repositorios
{
    internal class EstudianteUDLARepository : IEstudianteUDLARepository
    {

        public string _filename = Path.Combine(FileSystem.AppDataDirectory, "estudiante.txt");
        public bool ActualizarEstudianteUDLA(int Id, EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {

            try
            {
                string estudiante_json = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_filename, estudiante_json);

                return true;
            }

            catch (Exception e)
            {
                throw;

            }

        }

        public bool CrearEstudianteUDLA()
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id)
        {
            if (File.Exists(_filename))
            {

                string data = File.ReadAllText(_filename);

            }


        }

        public List<EstudianteUDLA> DevuelveListadoEstudianteUDLA()
        {
            List<EstudianteUDLA> estudiante = new List<EstudianteUDLA>();
            estudiante.Add(DevuelveInfoEstudianteUDLA(1));
            estudiante.Add(DevuelveInfoEstudianteUDLA(2));

            estudiante.Add(DevuelveInfoEstudianteUDLA(3));

            return estudiante;



        }

        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }

        public bool EstudianteUDLAFilesRepository(int id)
        {
            throw new NotImplementedException();
        }
    }
}
