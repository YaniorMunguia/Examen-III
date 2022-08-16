using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Examen_III
{
    public partial class AerolineaSilver : Syncfusion.Windows.Forms.Office2010Form
    {
        public AerolineaSilver()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;
        BindingList<Usuarios> listaVuelos = new BindingList<Usuarios>();

        Usuarios user;

        
        private void habilitarcontroles()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            habilitarcontroles();
            operacion = "nuevo";
        }

        private void listarVuelos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaVuelos;

        }
        private void AerolineaSilver_Load(object sender, EventArgs e)
        {
            listarVuelos();
        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                errorProvider1.SetError(textBox1, "Ingrese el vuelo");
                textBox1.Focus();
                return;
            }
            errorProvider1.Clear();


            if (textBox2.Text == String.Empty)
            {
                errorProvider1.SetError(textBox2, "Ingrese el Origen");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == String.Empty)
            {
                errorProvider1.SetError(textBox3, "Ingrese el Destino");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == String.Empty)
            {
                errorProvider1.SetError(textBox4, "Ingrese el numero de Pasajeros");
                textBox4.Focus();
                return;
            }
            if (textBox5.Text == String.Empty)
            {
                errorProvider1.SetError(textBox5, "Ingrese el Piloto");
                textBox5.Focus();
                return;
            }
            if (textBox6.Text == String.Empty)
            {
                errorProvider1.SetError(textBox6, "Ingrese la Hora de salida");
                textBox6.Focus();
                return;
            }

                if (textBox7.Text == String.Empty)
                {
                    errorProvider1.SetError(textBox7, "Ingrese la hora de llegada");
                    textBox7.Focus();
                    return;
                }

                if (textBox8.Text == String.Empty)
                {
                    errorProvider1.SetError(textBox8, "Ingrese la Fecha");
                    textBox8.Focus();
                    return;
                }

                user = new Usuarios();
                user.Vuelo = textBox1.Text;
                user.Origen = textBox2.Text;
                user.Destino = textBox3.Text;
                user.Pasajero = textBox4.Text;
                user.Piloto = textBox5.Text;
                user.Salida = textBox6.Text;
                user.Llegada = textBox7.Text;
                user.Fecha = textBox8.Text;


                if (operacion == "nuevo")
                {
                    listaVuelos.Add(user);
                    listarVuelos();

                limpiar();

                }
                else if (operacion == "modificar")
                {
                    foreach (var item in listaVuelos)
                    {
                        if (item.Vuelo == textBox1.Text)
                        {
                            item.Origen = textBox2.Text;
                            item.Destino = textBox3.Text;
                            item.Pasajero = textBox4.Text;
                            item.Piloto = textBox5.Text;
                            item.Salida = textBox6.Text;
                            item.Llegada = textBox7.Text;
                            item.Fecha = textBox8.Text;
                        }
                    }
                    listarVuelos();
                limpiar();
                }

            
        }

        private void gradientLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                operacion = "modificar";
                habilitarcontroles();
                textBox1.Text = dataGridView1.CurrentRow.Cells["Vuelo"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Origen"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Destino"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Pasajeros"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["Piloto"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["Salida"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["Llegada"].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (var item in listaVuelos)
                {
                    if (item.Vuelo == dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString())
                    {
                        listaVuelos.Remove(user);
                        break;
                    }

                }
            }
            listarVuelos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

