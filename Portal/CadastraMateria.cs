using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Portal
{
    public partial class CadastraMateria : Form
    {
        public CadastraMateria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var inicio = new TelaAdm();
            this.Hide();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // salvs
            Materia materia = new Materia();
            materia.Descricao = txt_descricao.Text;
            materia.DataCadastro = Convert.ToDateTime(txt_dataCadastro.Text);


            List<Materia> listaMateria = new GravarMateria().Add(materia);

            ListViewItem[] itens = new ListViewItem[listaMateria.Count];
            for (int i = 0; i < listaMateria.Count; i++)
            {
                itens[i] = new ListViewItem(listaMateria[i].Descricao,i);
            }
            list_view.Items.Clear();
            list_view.Items.AddRange(itens);
        }

        private void btn_salvarCadastro_Click(object sender, EventArgs e)
        {
            List<Materia> listaMateria = new GravarMateria().Deleta(txt_descricao.Text);
            ListViewItem[] itens = new ListViewItem[listaMateria.Count];
            for (int i = 0; i < listaMateria.Count; i++)
            {
                itens[i] = new ListViewItem(listaMateria[i].Descricao, i);
            }
            list_view.Items.Clear();
            list_view.Items.AddRange(itens);

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            var inicio = new TelaInicio();
            this.Hide();
            inicio.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CadastraMateria_Load(object sender, EventArgs e)
        {
            GravarCurso curso = new GravarCurso();
            List<Curso> listaCurso = new List<Curso>();
            listaCurso = curso.Busca();

            for (int i = 0; i < listaCurso.Count; i++)
            {
                cb_curso.Items.Add(listaCurso[i].NomeCurso);
            }
        }

        private void list_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
