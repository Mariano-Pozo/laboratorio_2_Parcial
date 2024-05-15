namespace Entidades
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha
        { 
            get 
            {
                return fecha;
            } 
        }
        public Paciente Paciente
        {
            get
            {
                return paciente;
            }
        }
        
        public Consulta(DateTime fecha, Paciente paciente)
        { 
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public override string ToString()
        {
            return $"{fecha} se ha atendido a {paciente.NombreCompleto}";
        }
    }
}