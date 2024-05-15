using Entidades;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));


        }


        private void btnAtender_Click_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItem is PersonalMedico doctor && lstPacientes.SelectedItem is Paciente paciente)
            {
                // Generar consulta con diagnóstico "Paciente curado"
                paciente.Diagnostico = "Paciente curado";
                //doctor += paciente;

                // Deseleccionar ambos ListBox
                lstMedicos.ClearSelected();
                lstPacientes.ClearSelected();

                // Mostrar mensaje de atención finalizada
                MessageBox.Show($"Consulta:\n{paciente.Edad} se ha atendido a {paciente.NombreCompleto}", "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar RichTextBox con la ficha del médico
                rtbInfoMedico.Text = doctor.FichaPersonal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItem is PersonalMedico doctor)
            {
                rtbInfoMedico.Text = doctor.FichaPersonal();
            }
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbInfoMedico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}