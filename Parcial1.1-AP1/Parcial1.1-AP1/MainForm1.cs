using Parcial1._1_AP1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1._1_AP1
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void EvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEvaluacion evaluar = new  RegistroEvaluacion();

            evaluar.Show();
        }

       
    }
}
