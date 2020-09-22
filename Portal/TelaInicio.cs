using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal
{
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaAdm = new TelaAdm();// tela que voce quer abrir
            this.Hide();//vai “esconder” o formulário atual
            telaAdm.Show(); // Abre nova tela
        }

        private void btn_prof_Click(object sender, EventArgs e)
        {
            var telaProf = new CadastraNota();
            this.Hide();
            telaProf.Show(); 
        }

        private void btn_aluno_Click(object sender, EventArgs e)
        {
            var telaAluno = new TelaAluno();
            this.Hide();
            telaAluno.Show(); 
        }
    }
}
