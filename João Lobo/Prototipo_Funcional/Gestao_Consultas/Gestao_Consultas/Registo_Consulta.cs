using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Consultas
{
    public partial class Registo_Consulta : Form
    {
        public Registo_Consulta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo_Sintomas sint = new Registo_Sintomas();
            sint.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo_Diagnostico dia = new Registo_Diagnostico();
            dia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registar_Receita re = new Registar_Receita();
            re.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_Medico hm = new Historial_Medico();
            hm.Show();
        }
    }
}
