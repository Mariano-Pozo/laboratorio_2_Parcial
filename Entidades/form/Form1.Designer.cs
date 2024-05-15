namespace form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtender_Click = new Button();
            btnSalir_Click = new Button();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            label1 = new Label();
            label2 = new Label();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // btnAtender_Click
            // 
            btnAtender_Click.Location = new Point(626, 27);
            btnAtender_Click.Name = "btnAtender_Click";
            btnAtender_Click.Size = new Size(148, 60);
            btnAtender_Click.TabIndex = 0;
            btnAtender_Click.Text = "Atender";
            btnAtender_Click.UseVisualStyleBackColor = true;
            btnAtender_Click.Click += btnAtender_Click_Click;
            // 
            // btnSalir_Click
            // 
            btnSalir_Click.Location = new Point(626, 330);
            btnSalir_Click.Name = "btnSalir_Click";
            btnSalir_Click.Size = new Size(148, 60);
            btnSalir_Click.TabIndex = 2;
            btnSalir_Click.Text = "Salir";
            btnSalir_Click.UseVisualStyleBackColor = true;
            btnSalir_Click.Click += btnSalir_Click_Click;
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 27);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(252, 214);
            lstMedicos.TabIndex = 3;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(294, 27);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(270, 214);
            lstPacientes.TabIndex = 5;
            lstPacientes.SelectedIndexChanged += lstPacientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 6;
            label1.Text = "Personal Medico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Pacientes";
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(7, 274);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(557, 152);
            rtbInfoMedico.TabIndex = 8;
            rtbInfoMedico.Text = "";
            rtbInfoMedico.TextChanged += rtbInfoMedico_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbInfoMedico);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(btnSalir_Click);
            Controls.Add(btnAtender_Click);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mariano Leonel Pozo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender_Click;
        private Button btnSalir_Click;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Label label1;
        private Label label2;
        private RichTextBox rtbInfoMedico;
    }
}