using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void v_Click(object sender, EventArgs e)
        {
            if (rbMunicipio.Checked == true)
            {

                Municipios.Items.Add(txtNombre.Text);
                txtNombre.Text = "";

            }
            else if (rbDepartamento.Checked == true) { 
            
                Departamentos.Items.Add(txtNombre.Text);
                txtNombre.Text = "";
            }


        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            foreach(var item in Municipios.Items)
            {
                Departamentos.Items.Add(item);
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {

            foreach (var item in Departamentos.Items)
            {
                Municipios.Items.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Municipios.Items.Clear();
            Departamentos.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
