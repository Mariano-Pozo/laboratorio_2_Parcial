using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente)
            :base(nombre,apellido,nacimiento)
        {
            this.esResidente = esRecidente;
            this.consultas = new List<Consulta>();
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó residencia? {(esResidente ? "SI" : "NO")}");
            sb.AppendLine("ATENCIONES:");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }
            return sb.ToString();
        }

        //public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        //{
        //    Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
        //    doctor.consulta.Add(nuevaConsulta);
        //    return nuevaConsulta;
        //
        //}
    }
}
