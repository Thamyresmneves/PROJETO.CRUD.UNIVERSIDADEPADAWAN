namespace Portal
{
    partial class TelaAluno
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.cb_aluno = new System.Windows.Forms.ComboBox();
            this.list_view = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualize sua Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o Aluno:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(171, 393);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(159, 36);
            this.btn_voltar.TabIndex = 6;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(430, 139);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(83, 220);
            this.btn_entrar.TabIndex = 7;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_aluno
            // 
            this.cb_aluno.FormattingEnabled = true;
            this.cb_aluno.Location = new System.Drawing.Point(12, 139);
            this.cb_aluno.Name = "cb_aluno";
            this.cb_aluno.Size = new System.Drawing.Size(379, 28);
            this.cb_aluno.TabIndex = 8;
            // 
            // list_view
            // 
            this.list_view.HideSelection = false;
            this.list_view.Location = new System.Drawing.Point(17, 194);
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(374, 165);
            this.list_view.TabIndex = 39;
            this.list_view.UseCompatibleStateImageBehavior = false;
            // 
            // TelaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 458);
            this.Controls.Add(this.list_view);
            this.Controls.Add(this.cb_aluno);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAluno";
            this.Text = "TelaAluno";
            this.Load += new System.EventHandler(this.TelaAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.ComboBox cb_aluno;
        private System.Windows.Forms.ListView list_view;
    }
}