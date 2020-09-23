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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_aluno = new System.Windows.Forms.Button();
            this.btn_prof = new System.Windows.Forms.Button();
            this.btn_adm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Universidade Padawan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Portal.Properties.Resources.imag1;
            this.pictureBox1.Location = new System.Drawing.Point(-891, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_aluno
            // 
            this.btn_aluno.BackColor = System.Drawing.Color.Transparent;
            this.btn_aluno.BackgroundImage = global::Portal.Properties.Resources.fundo_011;
            this.btn_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_aluno.Image = ((System.Drawing.Image)(resources.GetObject("btn_aluno.Image")));
            this.btn_aluno.Location = new System.Drawing.Point(31, 146);
            this.btn_aluno.Name = "btn_aluno";
            this.btn_aluno.Size = new System.Drawing.Size(205, 65);
            this.btn_aluno.TabIndex = 2;
            this.btn_aluno.Text = "Aluno";
            this.btn_aluno.UseVisualStyleBackColor = false;
            this.btn_aluno.Click += new System.EventHandler(this.btn_aluno_Click);
            // 
            // btn_prof
            // 
            this.btn_prof.BackgroundImage = global::Portal.Properties.Resources.EUiYD_lWoAAF9mO;
            this.btn_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prof.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prof.Image = global::Portal.Properties.Resources.imag;
            this.btn_prof.Location = new System.Drawing.Point(31, 254);
            this.btn_prof.Name = "btn_prof";
            this.btn_prof.Size = new System.Drawing.Size(205, 61);
            this.btn_prof.TabIndex = 1;
            this.btn_prof.Text = "Professor";
            this.btn_prof.UseVisualStyleBackColor = true;
            this.btn_prof.Click += new System.EventHandler(this.btn_prof_Click);
            // 
            // btn_adm
            // 
            this.btn_adm.BackgroundImage = global::Portal.Properties.Resources.EUiYD_lWoAAF9mO;
            this.btn_adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_adm.Image = global::Portal.Properties.Resources.imag;
            this.btn_adm.Location = new System.Drawing.Point(31, 367);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(205, 66);
            this.btn_adm.TabIndex = 0;
            this.btn_adm.Text = "Administrador";
            this.btn_adm.UseVisualStyleBackColor = true;
            this.btn_adm.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Portal.Properties.Resources.imag2;
            this.ClientSize = new System.Drawing.Size(859, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aluno);
            this.Controls.Add(this.btn_prof);
            this.Controls.Add(this.btn_adm);
            this.Name = "TelaInicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adm;
        private System.Windows.Forms.Button btn_prof;
        private System.Windows.Forms.Button btn_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

