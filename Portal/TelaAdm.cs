using System;
using System.Windows.Forms;

namespace Portal
{
    public partial class TelaAdm : Form
    {
        public TelaAdm()
        {
            InitializeComponent();
        }
       

        private void btn_entraAluno_Click(object sender, EventArgs e)
        {
            var aluno = new CadastraAluno();
            this.Hide();
            aluno.Show();
        }

        private void btn_entraProf_Click(object sender, EventArgs e)
        {
            var curso = new CadastraCurso();
            this.Hide();
            curso.Show();
        }

        private void btn_entradaAdm_Click(object sender, EventArgs e)
        {
            var materia = new CadastraMateria();
            this.Hide();
            materia.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inicio = new TelaInicio();
            this.Hide();
            inicio.Show();
        }
    }
}
