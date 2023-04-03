using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEmpresa
{
    public class Empleados
    {
        private string _nombre;
        private string _apellido;
        private string _cedula;

        public Empleados()
        {
            _nombre = "";
            _apellido = "";
            _cedula = "";
        }
        public Empleados(string nombre, string apellido, string cedula)
        {

            _nombre = nombre;
            _apellido = apellido;
            _cedula = cedula;

        }
        public string Nombre
        {

            set
            {
                _nombre = value;
            }

            get
            {
                return _nombre;
            }

        }
        public string Apellido
        {

            set
            {
                _apellido = value;
            }

            get
            {
                return _apellido;
            }

        }
        public string Cedula
        {

            set
            {
                _cedula = value;
            }

            get
            {
                return _cedula;
            }

        }
        public static List<Empleados> Lista() { 

        List<Empleados> ListEmpleado = new List<Empleados>();

        Empleados empleado1 = new Empleados("Maria", "Perez", "8.707.502");
        Empleados empleado2 = new Empleados("Francisco", "Ochoa", "25.266.567");
        Empleados empleado3 = new Empleados("Luis", "Galindez", "28.692.623");

        ListEmpleado.Add(empleado1);
        ListEmpleado.Add(empleado2);
        ListEmpleado.Add(empleado3);

            return ListEmpleado;
        }
    }
}
