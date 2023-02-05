namespace ProjetoCanalAlunoti91
{
    partial class F_Alunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dtp_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.Cb_Cursos = new System.Windows.Forms.ComboBox();
            this.Msk_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.LDATA = new System.Windows.Forms.Label();
            this.LCURSO = new System.Windows.Forms.Label();
            this.LCPF = new System.Windows.Forms.Label();
            this.LEMAIL = new System.Windows.Forms.Label();
            this.LNOME = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dtp_Nascimento);
            this.groupBox1.Controls.Add(this.Cb_Cursos);
            this.groupBox1.Controls.Add(this.Msk_Cpf);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.LDATA);
            this.groupBox1.Controls.Add(this.LCURSO);
            this.groupBox1.Controls.Add(this.LCPF);
            this.groupBox1.Controls.Add(this.LEMAIL);
            this.groupBox1.Controls.Add(this.LNOME);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(111, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Dtp_Nascimento
            // 
            this.Dtp_Nascimento.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.Dtp_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Nascimento.Location = new System.Drawing.Point(293, 209);
            this.Dtp_Nascimento.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Dtp_Nascimento.Name = "Dtp_Nascimento";
            this.Dtp_Nascimento.Size = new System.Drawing.Size(200, 26);
            this.Dtp_Nascimento.TabIndex = 11;
            // 
            // Cb_Cursos
            // 
            this.Cb_Cursos.BackColor = System.Drawing.Color.LightBlue;
            this.Cb_Cursos.FormattingEnabled = true;
            this.Cb_Cursos.Items.AddRange(new object[] {
            "PHP",
            "C#",
            "JAVA",
            "JAVASCRIPT",
            "C++"});
            this.Cb_Cursos.Location = new System.Drawing.Point(65, 207);
            this.Cb_Cursos.Name = "Cb_Cursos";
            this.Cb_Cursos.Size = new System.Drawing.Size(121, 28);
            this.Cb_Cursos.TabIndex = 10;
            // 
            // Msk_Cpf
            // 
            this.Msk_Cpf.BackColor = System.Drawing.Color.LightBlue;
            this.Msk_Cpf.Location = new System.Drawing.Point(367, 143);
            this.Msk_Cpf.Mask = "000.000.000-00";
            this.Msk_Cpf.Name = "Msk_Cpf";
            this.Msk_Cpf.Size = new System.Drawing.Size(126, 26);
            this.Msk_Cpf.TabIndex = 9;
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.LightBlue;
            this.tb_Email.Location = new System.Drawing.Point(65, 143);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(225, 26);
            this.tb_Email.TabIndex = 8;
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.Color.LightBlue;
            this.tb_nome.Location = new System.Drawing.Point(258, 75);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(235, 26);
            this.tb_nome.TabIndex = 7;
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.LightBlue;
            this.tb_ID.Location = new System.Drawing.Point(65, 75);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 26);
            this.tb_ID.TabIndex = 6;
            // 
            // LDATA
            // 
            this.LDATA.AutoSize = true;
            this.LDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDATA.Location = new System.Drawing.Point(287, 184);
            this.LDATA.Name = "LDATA";
            this.LDATA.Size = new System.Drawing.Size(206, 20);
            this.LDATA.TabIndex = 5;
            this.LDATA.Text = "DATA DE NASCIMENTO";
            // 
            // LCURSO
            // 
            this.LCURSO.AutoSize = true;
            this.LCURSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCURSO.Location = new System.Drawing.Point(61, 184);
            this.LCURSO.Name = "LCURSO";
            this.LCURSO.Size = new System.Drawing.Size(72, 20);
            this.LCURSO.TabIndex = 4;
            this.LCURSO.Text = "CURSO";
            // 
            // LCPF
            // 
            this.LCPF.AutoSize = true;
            this.LCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCPF.Location = new System.Drawing.Point(363, 120);
            this.LCPF.Name = "LCPF";
            this.LCPF.Size = new System.Drawing.Size(43, 20);
            this.LCPF.TabIndex = 3;
            this.LCPF.Text = "CPF";
            // 
            // LEMAIL
            // 
            this.LEMAIL.AutoSize = true;
            this.LEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEMAIL.Location = new System.Drawing.Point(61, 120);
            this.LEMAIL.Name = "LEMAIL";
            this.LEMAIL.Size = new System.Drawing.Size(63, 20);
            this.LEMAIL.TabIndex = 2;
            this.LEMAIL.Text = "EMAIL";
            // 
            // LNOME
            // 
            this.LNOME.AutoSize = true;
            this.LNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNOME.Location = new System.Drawing.Point(254, 52);
            this.LNOME.Name = "LNOME";
            this.LNOME.Size = new System.Drawing.Size(60, 20);
            this.LNOME.TabIndex = 1;
            this.LNOME.Text = "NOME";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(61, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(296, 364);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(209, 56);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // F_Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALUNOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dtp_Nascimento;
        private System.Windows.Forms.ComboBox Cb_Cursos;
        private System.Windows.Forms.MaskedTextBox Msk_Cpf;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label LDATA;
        private System.Windows.Forms.Label LCURSO;
        private System.Windows.Forms.Label LCPF;
        private System.Windows.Forms.Label LEMAIL;
        private System.Windows.Forms.Label LNOME;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btn_enviar;
    }
}

