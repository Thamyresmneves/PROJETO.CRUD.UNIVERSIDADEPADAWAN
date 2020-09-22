namespace Portal
{
    partial class CadastraCurso
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
            this.btn_salvarCadastro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_situacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_leitura = new System.Windows.Forms.ListView();
            this.btn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salvarCadastro
            // 
            this.btn_salvarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarCadastro.Location = new System.Drawing.Point(29, 290);
            this.btn_salvarCadastro.Name = "btn_salvarCadastro";
            this.btn_salvarCadastro.Size = new System.Drawing.Size(100, 50);
            this.btn_salvarCadastro.TabIndex = 22;
            this.btn_salvarCadastro.Text = "salvar";
            this.btn_salvarCadastro.UseVisualStyleBackColor = true;
            this.btn_salvarCadastro.Click += new System.EventHandler(this.btn_salvarCadastro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Situacao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Curso";
            // 
            // txt_curso
            // 
            this.txt_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_curso.Location = new System.Drawing.Point(168, 93);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(138, 30);
            this.txt_curso.TabIndex = 12;
            this.txt_curso.Text = "adm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(159, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_situacao
            // 
            this.txt_situacao.FormattingEnabled = true;
            this.txt_situacao.Items.AddRange(new object[] {
            "Ativa",
            "Inativa"});
            this.txt_situacao.Location = new System.Drawing.Point(168, 161);
            this.txt_situacao.Name = "txt_situacao";
            this.txt_situacao.Size = new System.Drawing.Size(121, 28);
            this.txt_situacao.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Lista:";
            // 
            // txt_leitura
            // 
            this.txt_leitura.HideSelection = false;
            this.txt_leitura.Location = new System.Drawing.Point(346, 67);
            this.txt_leitura.Name = "txt_leitura";
            this.txt_leitura.Size = new System.Drawing.Size(180, 189);
            this.txt_leitura.TabIndex = 30;
            this.txt_leitura.UseCompatibleStateImageBehavior = false;
            this.txt_leitura.SelectedIndexChanged += new System.EventHandler(this.txt_leitura_SelectedIndexChanged);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(426, 289);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(100, 51);
            this.btn_menu.TabIndex = 31;
            this.btn_menu.Text = "menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // CadastraCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 381);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.txt_leitura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_situacao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_salvarCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_curso);
            this.Name = "CadastraCurso";
            this.Text = "CadastraCurso";
            this.Load += new System.EventHandler(this.CadastraCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvarCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txt_situacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView txt_leitura;
        private System.Windows.Forms.Button btn_menu;
    }
}