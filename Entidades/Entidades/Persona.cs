using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona (string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            :this (nombre,apellido,nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }


        public int Edad 
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto 
        {
            get
            {
                return $"{apellido}, {nombre}";
            }
        }

        internal abstract string FichaExtra();

        public string FichaPersonal ()//implementar  "Persona p"
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(NombreCompleto);
            sb.AppendLine($"EDAD: {Edad}");
            //sb.AppendLine($"BARRIO: {barrioRecidencia}");
            sb.AppendLine(FichaExtra());
            return sb.ToString();

            
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}