namespace Portal
{
    partial class TelaInicio
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
            this.btn_adm = new System.Windows.Forms.Button();
            this.btn_prof = new System.Windows.Forms.Button();
            this.btn_aluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_adm
            // 
            this.btn_adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adm.Location = new System.Drawing.Point(78, 112);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(294, 66);
            this.btn_adm.TabIndex = 0;
            this.btn_adm.Text = "Administrador";
            this.btn_adm.UseVisualStyleBackColor = true;
            this.btn_adm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_prof
            // 
            this.btn_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prof.Location = new System.Drawing.Point(78, 207);
            this.btn_prof.Name = "btn_prof";
            this.btn_prof.Size = new System.Drawing.Size(294, 61);
            this.btn_prof.TabIndex = 1;
            this.btn_prof.Text = "Professor";
            this.btn_prof.UseVisualStyleBackColor = true;
            this.btn_prof.Click += new System.EventHandler(this.btn_prof_Click);
            // 
            // btn_aluno
            // 
            this.btn_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aluno.Location = new System.Drawing.Point(78, 303);
            this.btn_aluno.Name = "btn_aluno";
            this.btn_aluno.Size = new System.Drawing.Size(294, 65);
            this.btn_aluno.TabIndex = 2;
            this.btn_aluno.Text = "Aluno";
            this.btn_aluno.UseVisualStyleBackColor = true;
            this.btn_aluno.Click += new System.EventHandler(this.btn_aluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem vindo Usuario!";
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aluno);
            this.Controls.Add(this.btn_prof);
            this.Controls.Add(this.btn_adm);
            this.Name = "TelaInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adm;
        private System.Windows.Forms.Button btn_prof;
        private System.Windows.Forms.Button btn_aluno;
        private System.Windows.Forms.Label label1;
    }
}

