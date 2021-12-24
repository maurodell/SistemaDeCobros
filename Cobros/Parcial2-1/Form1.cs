using Parcial2_1.Datos;
using Parcial2_1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Parcial2_1
{
    public partial class Form1 : Form
    {
        static public List<Cliente> _listaClientes;
        static public List<Cobro> _listaCobros;
        ClienteAMB gestorCliente;
        CobroGestor gestorCobro;

        public Form1()
        {
            InitializeComponent();
            panelCliente.Visible = true;
            gestorCliente = new ClienteAMB();
            gestorCobro = new CobroGestor();

            _listaClientes = new List<Cliente>();
            _listaCobros = new List<Cobro>();

        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (panelCliente.Visible != true)
            {
                panelCliente.Visible = true;
            }
            else
            {
                panelCliente.Visible = false;
            }
        }
        private void btnCobroAMB_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible != true)
            {
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                tableLayoutPanel1.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNuevoCli.Click += Botones;
            btnModCli.Click += Botones;
            btnBorrarCli.Click += Botones;
            btnCobroNuevo.Click += Botones;
            btnPagar.Click += Botones;
            btnOrdenar.Click += Botones;

            Cobro.eventoAviso += aviso;

            cmbTipo.Text = "Normal";

            /*----------------------DataGridView COBROS PENDIENTES-------------------------------*/
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].Name = "Codigo"; // name
            dataGridView2.Columns[0].HeaderText = "Codigo"; // header text
            dataGridView2.Columns[0].DataPropertyName = "Codigo";
            dataGridView2.Columns[1].Name = "Nombre"; // name
            dataGridView2.Columns[1].HeaderText = "Nombre"; // header text
            dataGridView2.Columns[1].DataPropertyName = "Nombre";
            dataGridView2.Columns[2].Name = "FechaVto"; // name
            dataGridView2.Columns[2].HeaderText = "FechaVto"; // header text
            dataGridView2.Columns[2].DataPropertyName = "FechaVto";
            dataGridView2.Columns[3].Name = "ImporteACobrar"; // name
            dataGridView2.Columns[3].HeaderText = "ImporteACobrar"; // header text
            dataGridView2.Columns[3].DataPropertyName = "ImporteACobrar";
            dataGridView2.Columns[4].Name = "Adicional"; // name
            dataGridView2.Columns[4].HeaderText = "Adicional"; // header text
            dataGridView2.Columns[4].DataPropertyName = "Adicional";
            dataGridView2.Columns[5].Name = "Recargo"; // name
            dataGridView2.Columns[5].HeaderText = "Recargo"; // header text
            dataGridView2.Columns[5].DataPropertyName = "Recargo";
            /*---------------------------------------------------------------------------*/


            /*----------------------DataGridView CLIENTE-------------------------------*/
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Legajo"; // name
            dataGridView1.Columns[0].HeaderText = "Legajo"; // header text
            dataGridView1.Columns[0].DataPropertyName = "Legajo";
            dataGridView1.Columns[1].Name = "Nombre"; // name
            dataGridView1.Columns[1].HeaderText = "Nombre"; // header text
            dataGridView1.Columns[1].DataPropertyName = "Nombre";
            /*---------------------------------------------------------------------------*/

            /*----------------------DataGridView COBRAS PAGADOS ORDENADOS-------------------------------*/
            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.ColumnCount = 3;
            dataGridView5.Columns[0].Name = "Codigo"; // name
            dataGridView5.Columns[0].HeaderText = "Codigo"; // header text
            dataGridView5.Columns[0].DataPropertyName = "Codigo";
            dataGridView5.Columns[1].Name = "Nombre"; // name
            dataGridView5.Columns[1].HeaderText = "Nombre"; // header text
            dataGridView5.Columns[1].DataPropertyName = "Nombre";
            dataGridView5.Columns[2].Name = "ImportePagado"; // name
            dataGridView5.Columns[2].HeaderText = "Importe Total"; // header text
            dataGridView5.Columns[2].DataPropertyName = "ImportePagado";
            /*---------------------------------------------------------------------------*/

            ActualizarGrilla(dataGridView2, _listaCobros);
            ActualizarGrilla(dataGridView3, _listaCobros);
            ActualizarGrilla(dataGridView4, _listaCobros);
            ActualizarGrilla(dataGridView5, _listaCobros);
        }

        private void aviso()
        {
            MessageBox.Show("El importe supera los 10.000 pesos");
            //Cobro.eventoAviso -= aviso;
        }

        public void ActualizarGrilla(DataGridView dtgv, object obj)
        {
            dtgv.DataSource = null;
            dtgv.DataSource = obj;
        }
        private void Botones(object sender, EventArgs e)
        {
            Button seleccion = sender as Button;
            Cliente _cliente = new Cliente();

            switch (seleccion.Name)
            {
                case "btnNuevoCli":
                    if (ValidarCliente())
                    {
                        _cliente.Legajo = Convert.ToInt32(txtLegajo.Text);
                        _cliente.Nombre = txtNombre.Text;

                        if (gestorCliente.Existe(_cliente, _listaClientes))
                        {

                            MessageBox.Show($"El Legajo {_cliente.Legajo} ya existe");
                            txtLegajo.Text = "";
                        }
                        else
                        {
                            gestorCliente.Agregar(_cliente, _listaClientes);
                            ActualizarGrilla(dataGridView1, _listaClientes);

                            MessageBox.Show("Cliente Agregado");
                            LimpiarTxtCliente();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Agregar Datos!");
                    }
                    break;
                case "btnModCli":
                    try
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            Cliente _auxCliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                            _cliente.Legajo = _auxCliente.Legajo;
                            _cliente.Nombre = Interaction.InputBox("NOMBRE CLIENTE:", "Modificar Nombre");
                            gestorCliente.Modificar(_cliente, _listaClientes);
                            ActualizarGrilla(dataGridView1, _listaClientes);

                            MessageBox.Show($"Cliente con legajo N°{_cliente.Legajo} fue modificado");
                        }
                        else
                        {
                            MessageBox.Show("Grilla Vacía", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception)
                    {

                        throw new Exception("Error no esperado");
                    }

                    break;
                case "btnBorrarCli":
                    try
                    {
                        if (dataGridView1.SelectedRows.Count>0)
                        {
                            Cliente _auxCliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                            gestorCliente.Borrar(_auxCliente, _listaClientes);

                            ActualizarGrilla(dataGridView1, _listaClientes);
                            MessageBox.Show($"Cliente con legajo N°{_auxCliente.Legajo} fue borrado");
                        }
                        else
                        {
                            MessageBox.Show("Grilla Vacía", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception)
                    {

                        throw new Exception("Error no esperado");
                    }
                    break;
                case "btnCobroNuevo":
                    try
                    {
                        if (ValidarCobro())
                        {
                            Cobro cobro;
                            if (cmbTipo.Text == "Normal")
                            {
                                cobro = new Normal();
                            }
                            else
                            {
                                cobro = new Especial();
                            }

                            cobro.Codigo = Convert.ToInt32(txtCodCobro.Text);
                            cobro.Nombre = txtNomCobro.Text;
                            cobro.ImporteACobrar = Convert.ToDouble(txtImporteCobro.Text);
                            cobro.FechaVto = dateVto.Value;

                            Cliente _seleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                            Cliente _clienteCobro = new Cliente();
                            _clienteCobro.Legajo = _seleccionado.Legajo;
                            _clienteCobro.Nombre = _seleccionado.Nombre;

                            //paso el cliente al cobro
                            cobro.Cliente = _clienteCobro;
                            int contadorCobros = _seleccionado.cobrosClientes.Count;

                            //Control de cantidad de cobros por cliente
                            if (contadorCobros > 1)
                            {
                                MessageBox.Show("No puede tener mas de 2 cobros pendientes!");
                                LimpiarTxtCobro();
                            }
                            else 
                                if (gestorCobro.Existe(cobro, _seleccionado.cobrosClientes))
                            {
                                MessageBox.Show($"El cobro codigo N°{cobro.Codigo} ya existe");
                                txtCodCobro.Text = "";
                            }
                            else
                                if (gestorCobro.ExistePago(cobro, _seleccionado))
                            {
                                MessageBox.Show($"El cobro codigo N°{cobro.Codigo} ya fue pagado");
                                txtCodCobro.Text = "";
                            }
                            else
                            {
                                gestorCobro.AgregarCobro(cobro, _listaCobros);
                                MessageBox.Show("Cobro Agregado Correctamente");

                                ActualizarGrilla(dataGridView2, ActualizarCobroPorCliente());

                                //paso el cobro al cliente
                                _seleccionado.AgregarCobro(cobro);
                                LimpiarTxtCobro();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Algunos de los campos estan vacíos", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Debe agregar o seleccionar un cliente!");
                    }
                    break;
                case "btnPagar":
                    try
                    {
                        if (dataGridView2.SelectedRows.Count>0)
                        {
                            Cobro _auxCobro = dataGridView2.SelectedRows[0].DataBoundItem as Cobro;
                            Cliente _auxCliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                            foreach (var pago in _auxCliente.cobrosClientes)
                            {
                                if (pago.Codigo == _auxCobro.Codigo)
                                {
                                    _auxCliente.cobrosClientes.Remove(pago);
                                    _auxCliente.cobrosPagadosClientes.Add(pago);
                                    break;
                                }
                            }
                            gestorCobro.ControlPago(_auxCobro);

                            ActualizarGrilla(dataGridView2, gestorCliente.CobrosDeUnCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente, _listaClientes));
                            ActualizarGrilla(dataGridView3, gestorCobro.PagosCancelados(_auxCliente));
                            ActualizarGrilla(dataGridView4, gestorCobro.CobrosPagados(_auxCliente, _listaCobros));
                            ActualizarGrilla(dataGridView5, gestorCobro.PagosCancelados(_auxCliente));
                        }
                        else
                        {
                            MessageBox.Show("No hay cobros pendientes por pagar", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case "btnOrdenar":
                    try
                    {
                        if (dataGridView5.SelectedRows.Count>0)
                        {
                            //realizo un arraylist para usar el sort y reverse
                            ArrayList cobroOrden = new ArrayList();

                            //lista auxiliar para pasar los objetos ordenados
                            List<Cobro> prueba = new List<Cobro>();

                            //selecciono el cliente de la grilla 1 y paso los cobros pagados para poder ordenar
                            Cliente _select = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                            cobroOrden.AddRange(_select.cobrosPagadosClientes);
                        
                            //comprueba el checked de los radioButton
                            if (rBtnAsc.Checked != false)
                            {
                                cobroOrden.Reverse();
                            }
                            else
                            {
                                cobroOrden.Sort();
                            }

                            if (rBtnDes.Checked != false)
                            {
                                cobroOrden.Reverse();
                            }
                            else
                            {
                                cobroOrden.Sort();
                            }

                            //paso los objetos ordenados del ArrayList a una Lista para poder mostrarlos en la grilla.
                            foreach (Cobro item in cobroOrden)
                            {
                                prueba.Add(item);
                            }
                            ActualizarGrilla(dataGridView5, prueba);
                        }
                        else
                        {
                            MessageBox.Show("No hay cobros pagados por ordenar!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    break;
            }
        }
        private bool ValidarCliente()
        {
            string leg = txtLegajo.Text;
            string nom = txtNombre.Text;
            bool flag = false;
            if (leg != "" && nom != "")
            {
                flag = true;
            }
            return flag;
        }
        private bool ValidarCobro()
        {
            string cod = txtCodCobro.Text;
            string nom = txtNomCobro.Text;
            string importe = txtImporteCobro.Text;
            bool flag = false;
            if (cod != "" && nom != "" && importe != "")
            {
                flag = true;
            }
            return flag;
        }
        private void LimpiarTxtCliente()
        {
            txtLegajo.Text = "";
            txtNombre.Text = "";
        }
        private void LimpiarTxtCobro()
        {
            txtCodCobro.Text = "";
            txtNomCobro.Text = "";
            txtImporteCobro.Text = "";
        }
        public List<Cobro> ActualizarCobroPorCliente()
        {
            List<Cobro> _auxLista = new List<Cobro>();
            if (dataGridView1.SelectedRows.Count>0)
            {
                Cliente auxCliente = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;

                foreach (var cob in _listaCobros)
                {
                    if (cob.Cliente.Legajo == auxCliente.Legajo && cob.Cancelado!=true)
                    {
                        _auxLista.Add(cob);
                    }
                }
            }
            return _auxLista;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ActualizarGrilla(dataGridView2, gestorCliente.CobrosDeUnCliente(dataGridView1.SelectedRows[0].DataBoundItem as Cliente, _listaClientes));
                ActualizarGrilla(dataGridView3, gestorCobro.PagosCancelados(dataGridView1.SelectedRows[0].DataBoundItem as Cliente));
                ActualizarGrilla(dataGridView4, gestorCobro.CobrosPagados(dataGridView1.SelectedRows[0].DataBoundItem as Cliente, _listaCobros));
                ActualizarGrilla(dataGridView5, gestorCobro.PagosCancelados(dataGridView1.SelectedRows[0].DataBoundItem as Cliente));
            }
            catch (Exception)
            {

            }
        }
    }
}
