using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public string diagnostico;//?

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) 
            : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
        }

        public string Diagnostico 
        { 
            get 
            { 
                return diagnostico; 
            } 
            set 
            {  
                diagnostico = value; 
            } 
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recide en: {barrioRecidencia}");
            sb.AppendLine(diagnostico);
            return sb.ToString();

        }


    }
}
