using Parcial1._1_AP1.BLL;
using Parcial1._1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1._1_AP1.UI.Registros
{
    public partial class RegistroEvaluacion : Form
    {
        public RegistroEvaluacion()
        {
            InitializeComponent();
        }

        
        private void Limpiar()
        {
            IDEvaluacionnumericUpDown1.Value = 0;
            NombretextBox1.Text = string.Empty;
            FechadateTimePicker1.Value = DateTime.Now;
            PerdidotextBox4.Text = string.Empty;
            ObtenidotextBox3.Text = string.Empty;
            ValortextBox2.Text = string.Empty;
            MyErrorProvider1.Clear();

        }

        private void LlenarCampo(Evaluacion evaluar)
        {

            IDEvaluacionnumericUpDown1.Value = evaluar.IDEvaluacion;
            NombretextBox1.Text = evaluar.nombre;
            FechadateTimePicker1.Value = evaluar.Fecha;
            ValortextBox2.Text = Convert.ToString(evaluar.Valor);
            ObtenidotextBox3.Text = Convert.ToString(evaluar.Obtenido);
            PerdidotextBox4.Text = Convert.ToString(evaluar.Perdido);

        }

        private Evaluacion LLenaClase()
        {
            Evaluacion evaluar = new Evaluacion();
            evaluar.IDEvaluacion = Convert.ToInt32(IDEvaluacionnumericUpDown1.Value);
            evaluar.nombre = NombretextBox1.Text;
            evaluar.Obtenido = Convert.ToDecimal(ObtenidotextBox3.Text);


            return evaluar;
        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {

            Limpiar();
        }


        private void Guardarbutton2_Click(object sender, EventArgs e)
        {
            Evaluacion evaluar;
            bool paso = false;

            if (!Validar())
                return;
            evaluar = LLenaClase();

            if (IDEvaluacionnumericUpDown1.Value == 0)
                paso = EvaluacionBLL.Guardar(evaluar);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "fallo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton3_Click(object sender, EventArgs e)
        {
            MyErrorProvider1.Clear();

            int id;
            int.TryParse(IDEvaluacionnumericUpDown1.Text, out id);

            Limpiar();

            if (EvaluacionBLL.Eliminar(id))
                MessageBox.Show("Eliminado", " Con Exito..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider1.SetError(IDEvaluacionnumericUpDown1, "No se puede eliminar un estudiante que no existe");
        }

        private void Buscarbutton4_Click(object sender, EventArgs e)
        {
            int id;
            Evaluacion evaluar = new Evaluacion();
            int.TryParse(IDEvaluacionnumericUpDown1.Text, out id);

            Limpiar();

            evaluar = EvaluacionBLL.Buscar(id);

            if (evaluar != null)
            {
                MessageBox.Show("Evaluacion encontrada.");
                LlenarCampo(evaluar);

            }
            else
            {
                MessageBox.Show("Evaluacion no encontrada.");
            }
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(NombretextBox1.Text))
            {
                MyErrorProvider1.SetError(NombretextBox1, "El campo de evaluacion no puede estar vacio...");
                NombretextBox1.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ValortextBox2.Text))
            {
                MyErrorProvider1.SetError(ValortextBox2, "El campo valor no puede estar vacio...");
                ValortextBox2.Focus();
                paso = false;
            }

            return paso;

        }


    }
}
