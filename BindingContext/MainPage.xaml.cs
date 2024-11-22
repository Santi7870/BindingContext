using BindingContext.Models;
using BindingContext.Repositorios;

namespace BindingContext
{
    public partial class MainPage : ContentPage
    {
        public EstudianteUDLA estudiante;
        EstudianteUDLARepository repositorios;

        public MainPage()
        {
            InitializeComponent();
            repositorios = new EstudianteUDLARepository();
            estudiante = repositorios.DevuelveInfoEstudianteUDLA(1);


            BindingContext = estudiante;
        }

        private void BotonGuardarEstudiante_Clicked(object sender, EventArgs e) 
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                ID = 10,
                Nombre = "Santiago",
                Carrera = "Sofware"

            };

            repositorios.CrearEstudianteUDLA(estudiante);

            
            

        }

    }

}
