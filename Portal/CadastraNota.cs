using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Portal
{
    public partial class CadastraNota : Form
    {
        public CadastraNota()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var inicio = new TelaInicio();
            this.Hide();
            inicio.Show();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Valor = txt_notaN.Text;
            nota.Aluno = cb_aluno.Text;
            nota.Materia = cb_materia.Text;

            List<Materia> listaMateria = new GravarMateria().Busca();
            ListViewItem[] itenss = new ListViewItem[listaMateria.Count];
            for (int i = 0; i < listaMateria.Count; i++)
            {
                itenss[i] = new ListViewItem(listaMateria[i].Descricao, i);
            }


            List<Nota> listaNotas = new GravarNota().Add(nota);
            MessageBox.Show("Nota cadastrada com sucesso!");
            ListViewItem[] itens = new ListViewItem[listaNotas.Count];
            for (int i = 0; i < listaNotas.Count; i++)
            {
                itens[i] = new ListViewItem(listaNotas[i].Valor, i);
            }

            list_view.Items.Clear();
            list_view.Items.AddRange(itenss);
            list_view.Items.AddRange(itens);

        }

        private void TelaProfessor_Load(object sender, EventArgs e)
        {
            GravarAluno chamadaAluno = new GravarAluno();
            List<Aluno> listaAluno = new List<Aluno>();
              listaAluno = chamadaAluno.Busca();

            for (int i = 0; i < listaAluno.Count; i++)
            {
                cb_aluno.Items.Add(listaAluno[i].Nome);
            }

            GravarMateria chamadaMateria = new GravarMateria();
            List<Materia> listaMateria = chamadaMateria.Busca();

            for (int i = 0; i < listaMateria.Count; i++)
            {
                cb_materia.Items.Add(listaMateria[i].Descricao);
            }


        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            List<Nota> listaNota = new GravarNota().Deleta(cb_aluno.Text);
            ListViewItem[] itens = new ListViewItem[listaNota.Count];
            for (int i = 0; i < listaNota.Count; i++)
            {
                itens[i] = new ListViewItem(listaNota[i].Materia, i);
            }
            list_view.Items.Clear();
            list_view.Items.AddRange(itens);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            var inicio = new TelaInicio();
            this.Hide();
            inicio.Show();
        }
    }
}
