using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROYECTO_ESCUELA
{
    public partial class AgregarAlumno : Form
    {

        public Registro objproducto = new Registro();
        string operacion = "insertar";

        public AgregarAlumno()
        {
            InitializeComponent();
        }


        private void btn_altas_Click_1(object sender, EventArgs e)
        {
            if (tx_curp.Text == "" || tx_nombre.Text == "" || tx_paterno.Text == "" || tx_materno.Text == "" || tx_edad.Text == "" || tx_fecha.Text == "" || tx_grado.Text == "" || tx_sexo.Text == "" || tx_sangre.Text=="" || tx_alergia.Text==""
                   || tx_nomtutor.Text == "" || tx_patertutor.Text == "" || tx_matertutor.Text == "" || tx_correo.Text == "" || tx_estudio.Text == "" || tx_calle.Text == "" || tx_colonia.Text == ""
                   || tx_lote.Text == "" || tx_cp.Text == "" || tx_manza.Text == "" || tx_celular.Text == "" || tx_telefono.Text == "")
            {
                MessageBox.Show("Faltan Campos por Rellenar.", "Lo sentimos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
          {
                if (operacion == "insertar")
                {
                    if (!objproducto.Existe(Convert.ToString(tx_curp.Text)))
                    {
                        objproducto.insertarAlumno(tx_curp.Text, tx_nombre.Text, tx_paterno.Text, tx_materno.Text, Convert.ToInt32(tx_edad.Text), tx_fecha.Text, tx_grado.Text, tx_sexo.Text, Convert.ToString(tx_sangre.Text), tx_alergia.Text);
                        objproducto.insertartutor(tx_curp.Text, tx_nomtutor.Text, tx_patertutor.Text, tx_matertutor.Text, tx_correo.Text, tx_estudio.Text, tx_calle.Text, tx_colonia.Text, tx_lote.Text, tx_cp.Text, tx_manza.Text, tx_celular.Text,tx_telefono.Text);
                        listaralum();
                        MessageBox.Show("Agregado Correctamente");

                    }
                    else
                    {
                        MessageBox.Show("El Alumno ya existe");
                        tx_curp.Text = "";
                    }
                }
                else
                {
                    if (operacion == "editar")
                    {
                        objproducto.editar(tx_curp.Text, tx_nombre.Text, tx_paterno.Text, tx_materno.Text, Convert.ToInt32(tx_edad.Text),
                            tx_fecha.Text, tx_grado.Text, tx_sexo.Text,tx_sangre.Text,tx_alergia.Text);
                        objproducto.editartutor(tx_curp.Text, tx_nomtutor.Text, tx_patertutor.Text, tx_matertutor.Text, tx_correo.Text, tx_estudio.Text,
                            tx_calle.Text, tx_colonia.Text, tx_lote.Text, Convert.ToInt32(tx_cp.Text), tx_manza.Text,tx_celular.Text,
                            tx_telefono.Text);
                        operacion = "insertar";
                        MessageBox.Show("actualizada bien");
                    }
                    listaralum();
                }
            }
        }
        private void listaralum()
        {
            Registro objprod = new Registro();
            dataGridView1.DataSource = objprod.listaralumno();
        }

        private void tx_curp_Enter(object sender, EventArgs e)
        {
            if (tx_curp.Text == "Escribir la Curp")

                tx_curp.Text = "";
            tx_curp.ForeColor = Color.Black;
        }

        private void tx_correo_Enter(object sender, EventArgs e)
        {
            if (tx_correo.Text == "usuario@gmail.com")

                tx_correo.Text = "";
            tx_curp.ForeColor = Color.Black;
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void AgregarAlumno_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = objproducto.listaralumno();
           dataGridView1.Columns[10].HeaderText = "NombreTutor";
            dataGridView1.Columns[11].HeaderText = "Paterno";
            dataGridView1.Columns[12].HeaderText = "Materno";
            dataGridView1.Columns[16].HeaderText = "Colonia";

            listaralum();
            if(Program.perfil=="Directora")
            {
                btn_modificar.Enabled=true;
                btn_bajas.Enabled = true;
            }
            else
            {
                btn_modificar.Enabled = false;
                btn_bajas.Enabled =false;

            }
        }

        private void tx_curp_Leave(object sender, EventArgs e)
        {
            Regex val = new Regex(@"^[A-ZA-Z]{4,4}[0-9]{6}[A-ZA-A]{6,6}[0-9]{2}$");
            
                if (val.IsMatch(tx_curp.Text))
                {
                    String year = tx_curp.Text.Substring(4, 2);
                    String month = tx_curp.Text.Substring(6, 2);
                    String day = tx_curp.Text.Substring(8, 2);

                    tx_año.Text = 20 + Convert.ToString(year);
                    tx_mes.Text = Convert.ToString(month);
                    tx_dia.Text = Convert.ToString(day);

                    tx_fecha.Text = tx_dia.Text + "-"+ tx_mes.Text + "-"+tx_año.Text;

                    if (tx_año.Text == "2006" || tx_año.Text == "2007" || tx_año.Text == "2008" || tx_año.Text == "2009" || tx_año.Text == "2010" || tx_año.Text == "2011" || tx_año.Text == "2012")
                    {
                        if (tx_año.Text == "2006")
                        {
                            tx_edad.Text = "12";
                            tx_grado.Text = "6°A";
                        }
                        else
                        {
                        if (tx_año.Text == "2007")
                        {
                            tx_edad.Text = "11";
                            tx_grado.Text = "6°A";
                        }
                        else
                        {
                            if (tx_año.Text == "2008")
                            {
                                tx_edad.Text = "10";
                                tx_grado.Text = "5°A";
                            }
                            else
                            {
                                if (tx_año.Text == "2009")
                                {
                                    tx_edad.Text = "9";
                                    tx_grado.Text = "4°A";
                                }
                                else
                                {
                                    if (tx_año.Text == "2010")
                                    {
                                        tx_edad.Text = "8";
                                        tx_grado.Text = "3°A";
                                    }
                                    else
                                    {
                                        if (tx_año.Text == "2011")
                                        {
                                            tx_edad.Text = "7";
                                            tx_grado.Text = "2°A";
                                        }
                                        else
                                        {
                                            if (tx_año.Text == "2012")
                                            {
                                                tx_edad.Text = "6";
                                                tx_grado.Text = "1°A";
                                            }
                                        }
                                    }
                                }
                            }
                        }  }
                    }
                    else
                    {
                    tx_año.Text = "";
                    tx_año.Text = 19 + Convert.ToString(year);
                    tx_mes.Text = Convert.ToString(month);
                    tx_dia.Text = Convert.ToString(day);

                    tx_fecha.Text = tx_dia.Text + "-" + tx_mes.Text + "-" + tx_año.Text;
                    MessageBox.Show("Invalido");
                        tx_fecha.Text ="";
                    }
                }
                else
                {
                    MessageBox.Show("Curp invalida.Favor de Verificar", "AVISO  Sistema de Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tx_curp.Text ="";
                }
            }              
        private void tx_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.numero(e);
        }

        private void tx_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.numero(e);
        }

        private void tx_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_paterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_materno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_nomtutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_patertutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_matertutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_estudio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.letra(e);
        }

        private void tx_cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.numero(e);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
           
            if(dataGridView1.SelectedRows.Count>0)
            {
                tx_curp.Enabled = false;
                operacion = "editar";
                tx_curp.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tx_nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                tx_paterno.Text = dataGridView1.CurrentRow.Cells["Paterno"].Value.ToString();
                tx_materno.Text = dataGridView1.CurrentRow.Cells["Materno"].Value.ToString();
                tx_edad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                tx_fecha.Text = dataGridView1.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                tx_grado.Text = dataGridView1.CurrentRow.Cells["Grado"].Value.ToString();
                tx_sexo.Text = dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString();
                tx_sangre.Text = dataGridView1.CurrentRow.Cells["Tipo_Sangre"].Value.ToString();
                tx_alergia.Text = dataGridView1.CurrentRow.Cells["Alergia"].Value.ToString();
                tx_nomtutor.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
               tx_patertutor.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                tx_matertutor.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                tx_correo.Text = dataGridView1.CurrentRow.Cells["correo"].Value.ToString();
                tx_estudio.Text = dataGridView1.CurrentRow.Cells["grado_estudios"].Value.ToString();
                tx_calle.Text = dataGridView1.CurrentRow.Cells["calle"].Value.ToString();
                tx_colonia.Text = dataGridView1.CurrentRow.Cells["colinia"].Value.ToString();
                tx_lote.Text = dataGridView1.CurrentRow.Cells["lote"].Value.ToString();
                tx_cp.Text = dataGridView1.CurrentRow.Cells["cp"].Value.ToString();
                tx_manza.Text = dataGridView1.CurrentRow.Cells["manzana"].Value.ToString();
                tx_celular.Text = dataGridView1.CurrentRow.Cells["Celular"].Value.ToString();
                tx_telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();

            }
            else { MessageBox.Show("seleccione una fila"); }

        }
        private void btn_bajas_Click(object sender, EventArgs e)
        {
            objproducto.eliminartutor(Convert.ToString(dataGridView1.CurrentRow.Cells["Curp"].Value));
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objproducto.eliminarAlum(Convert.ToString(dataGridView1.CurrentRow.Cells["Curp"].Value));
                MessageBox.Show("se elimino correctamente");
                listaralum();
            }
            else
                MessageBox.Show("seleccione una fila");
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            tx_curp.Enabled=true;
            tx_curp.Text = "";
            tx_nombre.Text = "";
            tx_paterno.Text = "";
            tx_materno.Text = "";
            tx_edad.Text = "";
            tx_fecha.Text = "";
            tx_grado.Text = "";
            tx_sexo.Text = "";
            tx_sangre.Text = "";
            tx_alergia.Text = "";
            tx_nomtutor.Text = "";
            tx_patertutor.Text = "";
            tx_matertutor.Text = "";
            tx_calle.Text = "";
            tx_celular.Text = "";
            tx_colonia.Text = "";
            tx_correo.Text = "";
            tx_cp.Text = "";
            tx_estudio.Text = "";
            tx_lote.Text = "";
            tx_manza.Text = "";
            tx_telefono.Text = "";
            tx_sangre.Text = "";
            tx_alergia.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange_1(object sender, EventArgs e)
        {

           Registro sql = new Registro();
            if (tx_buscaralum.Text != "")
                dataGridView1.DataSource = sql.Buscar(tx_buscaralum.Text);
            else dataGridView1.DataSource = sql.listaralumno();
        }

        private void tx_correo_Leave(object sender, EventArgs e)
        {
                Regex Val = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (Val.IsMatch(tx_correo.Text))
                {

                }
                else
                {
                    MessageBox.Show("Correo invalido. Favor de Verificar", "◄ AVISO | Sistema de Control Escolar ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tx_correo.Text = "";
                }
            }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tx_curp_TextChange(object sender, EventArgs e)
        {

        }
    }
    }
