namespace Portal
{
    partial class TelaAdm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadaluno = new System.Windows.Forms.Button();
            this.btn_cadcurso = new System.Windows.Forms.Button();
            this.btn_cadmateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(99, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADMINISTRADOR";
            // 
            // btn_cadaluno
            // 
            this.btn_cadaluno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadaluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadaluno.Location = new System.Drawing.Point(227, 282);
            this.btn_cadaluno.Name = "btn_cadaluno";
            this.btn_cadaluno.Size = new System.Drawing.Size(205, 41);
            this.btn_cadaluno.TabIndex = 6;
            this.btn_cadaluno.Text = "Aluno";
            this.btn_cadaluno.UseVisualStyleBackColor = false;
            this.btn_cadaluno.Click += new System.EventHandler(this.btn_entraAluno_Click);
            // 
            // btn_cadcurso
            // 
            this.btn_cadcurso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadcurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadcurso.Location = new System.Drawing.Point(227, 207);
            this.btn_cadcurso.Name = "btn_cadcurso";
            this.btn_cadcurso.Size = new System.Drawing.Size(205, 44);
            this.btn_cadcurso.TabIndex = 5;
            this.btn_cadcurso.Text = "Curso";
            this.btn_cadcurso.UseVisualStyleBackColor = false;
            this.btn_cadcurso.Click += new System.EventHandler(this.btn_entraProf_Click);
            // 
            // btn_cadmateria
            // 
            this.btn_cadmateria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadmateria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadmateria.Location = new System.Drawing.Point(227, 132);
            this.btn_cadmateria.Name = "btn_cadmateria";
            this.btn_cadmateria.Size = new System.Drawing.Size(205, 47);
            this.btn_cadmateria.TabIndex = 4;
            this.btn_cadmateria.Text = "Materia";
            this.btn_cadmateria.UseVisualStyleBackColor = false;
            this.btn_cadmateria.Click += new System.EventHandler(this.btn_entradaAdm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cadastrar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(134, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portal.Properties.Resources.fundo_011;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadaluno);
            this.Controls.Add(this.btn_cadcurso);
            this.Controls.Add(this.btn_cadmateria);
            this.Name = "TelaAdm";
            this.Text = "TelaAdm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadaluno;
        private System.Windows.Forms.Button btn_cadcurso;
        private System.Windows.Forms.Button btn_cadmateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}