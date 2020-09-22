namespace Portal
{
    partial class CadastraNota
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_notaN = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.list_view = new System.Windows.Forms.ListView();
            this.cb_aluno = new System.Windows.Forms.ComboBox();
            this.cb_materia = new System.Windows.Forms.ComboBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo Professor!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aluno :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "nota :";
            // 
            // txt_notaN
            // 
            this.txt_notaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_notaN.Location = new System.Drawing.Point(114, 261);
            this.txt_notaN.Name = "txt_notaN";
            this.txt_notaN.Size = new System.Drawing.Size(81, 35);
            this.txt_notaN.TabIndex = 8;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(12, 358);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(97, 42);
            this.btn_salvar.TabIndex = 10;
            this.btn_salvar.Text = "salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.Location = new System.Drawing.Point(139, 352);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(106, 48);
            this.btn_apagar.TabIndex = 11;
            this.btn_apagar.Text = "apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(427, 355);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(115, 42);
            this.btn_voltar.TabIndex = 12;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // list_view
            // 
            this.list_view.HideSelection = false;
            this.list_view.Location = new System.Drawing.Point(418, 72);
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(240, 265);
            this.list_view.TabIndex = 17;
            this.list_view.UseCompatibleStateImageBehavior = false;
            // 
            // cb_aluno
            // 
            this.cb_aluno.FormattingEnabled = true;
            this.cb_aluno.Location = new System.Drawing.Point(114, 156);
            this.cb_aluno.Name = "cb_aluno";
            this.cb_aluno.Size = new System.Drawing.Size(280, 28);
            this.cb_aluno.TabIndex = 18;
            this.cb_aluno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_materia
            // 
            this.cb_materia.FormattingEnabled = true;
            this.cb_materia.Location = new System.Drawing.Point(114, 209);
            this.cb_materia.Name = "cb_materia";
            this.cb_materia.Size = new System.Drawing.Size(280, 28);
            this.cb_materia.TabIndex = 19;
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(548, 352);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(114, 45);
            this.btn_menu.TabIndex = 40;
            this.btn_menu.Text = "menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cadastro de notas";
            // 
            // CadastraNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.cb_materia);
            this.Controls.Add(this.cb_aluno);
            this.Controls.Add(this.list_view);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_notaN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastraNota";
            this.Text = "TelaProfessor";
            this.Load += new System.EventHandler(this.TelaProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_notaN;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ListView list_view;
        private System.Windows.Forms.ComboBox cb_aluno;
        private System.Windows.Forms.ComboBox cb_materia;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label label5;
    }
}