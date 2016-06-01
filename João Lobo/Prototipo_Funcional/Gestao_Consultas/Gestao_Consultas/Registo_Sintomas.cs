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
    public partial class Registo_Sintomas : Form
    {
        public Registo_Sintomas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo_Consulta menu = new Registo_Consulta();
            menu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Consulta newconsulta = new Consulta(textBox1.Text, textBox2.Text);

            List<Consulta> mylist = new List<Consulta>();
            mylist.Add(newconsulta);

            textBox1.Clear();
            textBox2.Clear();


            MessageBox.Show("Sintomas Registados com Sucesso");
        }
    }
}
