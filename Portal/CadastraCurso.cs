using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Portal
{
    public partial class CadastraCurso : Form
    {
        public CadastraCurso()
        {
            InitializeComponent();
        }

        private void CadastraCurso_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inicio = new TelaAdm();
            this.Hide();
            inicio.Show();
        }

        private void btn_salvarCadastro_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.NomeCurso = txt_curso.Text;          


            List<Curso> listaCurso = new GravarCurso().Add(curso);

            ListViewItem[] itens = new ListViewItem[listaCurso.Count];
            for (int i = 0; i < listaCurso.Count; i++)
            {
                itens[i] = new ListViewItem(listaCurso[i].NomeCurso, i);
            }
            txt_leitura.Items.Clear();
            txt_leitura.Items.AddRange(itens);
        }

        private void txt_leitura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Curso> listaCurso = new GravarCurso().Deleta(txt_curso.Text);
            ListViewItem[] itens = new ListViewItem[listaCurso.Count];
            for (int i = 0; i < listaCurso.Count; i++)
            {
                itens[i] = new ListViewItem(listaCurso[i].NomeCurso, i);
            }
            txt_leitura.Items.Clear();
            txt_leitura.Items.AddRange(itens);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            var inicio = new TelaInicio();
            this.Hide();
            inicio.Show();
        }

        private void txt_situacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
