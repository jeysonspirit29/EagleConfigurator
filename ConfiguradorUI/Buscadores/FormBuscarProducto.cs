﻿using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConfiguradorUI.Buscadores
{
    public partial class FormBuscarProducto : MetroForm
    {
        #region Variables
        public PROt09_producto producto = null;
        #endregion

        public FormBuscarProducto()
        {
            InitializeComponent();
        }

        #region Métodos

        void AddHandled()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            txtCodigo.KeyDown += FocusDgv_KeyDown;
            txtCodigo02.KeyDown += FocusDgv_KeyDown;
            txtDescripcionProd.KeyDown += FocusDgv_KeyDown;
        }

        private void FocusDgv_KeyDown(object sender, KeyEventArgs e)
       {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                dgvProd.Focus();
            }
        }

        private void CargarGrid(IEnumerable<PROt09_producto> list)
        {
            if (list != null)
            {
                dgvProd.DataSource = list.Select(x => new
                {
                    ID = x.id_producto,
                    CODIGO = x.cod_producto,
                    CODIGO02 = x.cod_producto2,
                    DESCRIPCION = x.txt_desc?.ToUpper(),
                    PVPU_CON_TAX = x.mto_pvpu_con_tax.RemoveTrailingZeros(),
                    PVPU_SIN_TAX = x.mto_pvpu_sin_tax,
                    ESTADO = x.txt_estado?.ToUpper(),
                    POR_IMPTO = x.por_impto,
                    PESO = x.peso_prod,
                    UM = x.id_um

                }).ToList();
            }
            else
            {
                var prodHeader = new List<TNSt05_comp_emitido_dtl>();
                dgvProd.DataSource = prodHeader.Select(x => new
                {
                    ID = "",
                    CODIGO = "",
                    CODIGO02 = "",
                    DESCRIPCION = "",
                    PVPU_CON_TAX = "",
                    PVPU_SIN_TAX = "",
                    ESTADO = "",
                    POR_IMPTO = "",
                    PESO = "",
                    UM = ""
                }).ToList();
            }
            DefinirCabeceraGrid();
        }

        private void BuscarProducto(bool verTodos = false)
        {
            var cod = txtCodigo.Text.Trim();
            var cod02 = txtCodigo02.Text.Trim();
            var nombre = txtDescripcionProd.Text.Trim();
            int? estado = chkIncluirInactivos.Checked ? Estado.Ignorar : Estado.IdActivo;
            if (verTodos)
            {
                cod = "";
                cod02 = "";
                nombre = "";
                estado = Estado.Ignorar;
            }

            var list = new ProductoBL().BuscarProducto(cod, cod02, nombre, Estado.IdActivo, Estado.Ignorar, estado);
            CargarGrid(list);
        }

        private void SetInicio()
        {
            AddHandled();
            ConfigurarControles();
            BuscarProducto();
            txtDescripcionProd.Focus();
        }

        private void DefinirCabeceraGrid()
        {
            try
            {
                dgvProd.Columns["ID"].Visible = false;
                //dgvProd.Columns["PVPU_CON_TAX"].Visible = false;
                dgvProd.Columns["PVPU_SIN_TAX"].Visible = false;
                dgvProd.Columns["POR_IMPTO"].Visible = false;
                dgvProd.Columns["PESO"].Visible = false;
                dgvProd.Columns["UM"].Visible = false;

                dgvProd.Columns["CODIGO"].HeaderText = "CÓDIGO 01";
                dgvProd.Columns["CODIGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProd.Columns["CODIGO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProd.Columns["CODIGO02"].HeaderText = "CÓDIGO 02";
                dgvProd.Columns["CODIGO02"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProd.Columns["CODIGO02"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProd.Columns["DESCRIPCION"].HeaderText = "DESCRIPCIÓN";

                dgvProd.Columns["PVPU_CON_TAX"].HeaderText = "PREC. UNIT";
                dgvProd.Columns["PVPU_CON_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProd.Columns["PVPU_CON_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProd.Columns["ESTADO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProd.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProd.Columns["DESCRIPCION"].Width = 435;
                dgvProd.Columns["CODIGO"].Width = 100;
                dgvProd.Columns["CODIGO02"].Width = 100;
                dgvProd.Columns["PVPU_CON_TAX"].Width = 100;
                dgvProd.Columns["ESTADO"].Width = 90;
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarControles()
        {
            #region Form
            MaximizeBox = false;
            Resizable = false;
            #endregion

            #region Checks

            chkIncluirInactivos.Checked = false;

            #endregion

            #region TextBox

            txtCodigo.MaxLength = 50;
            txtCodigo02.MaxLength = 50;
            txtDescripcionProd.MaxLength = 350;

            #endregion

            #region Grilla
            var prodHeader = new List<TNSt05_comp_emitido_dtl>();
            dgvProd.DataSource = prodHeader.Select(x => new
            {
                ID = "",
                CODIGO = "",
                CODIGO02 = "",
                DESCRIPCION = "",
                PVPU_CON_TAX = "",
                PVPU_SIN_TAX = "",
                ESTADO = "",
                POR_IMPTO = "",
                PESO = "",
                UM = ""

            }).ToList();
            DefinirCabeceraGrid();
            ControlHelper.DgvReadOnly(dgvProd);
            ControlHelper.DgvStyle(dgvProd);
            #endregion

        }

        private PROt09_producto GetProducto()
        {
            try
            {
                var prod = new PROt09_producto()
                {
                    id_producto = long.Parse(dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["ID"].Value.ToString()),
                    cod_producto = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["CODIGO"].Value.ToString(),
                    cod_producto2 = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["CODIGO02"].Value.ToString(),
                    txt_desc = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString(),
                    txt_estado = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["ESTADO"].Value.ToString(),
                    peso_prod = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["PESO"].Value.ToString()
                };

                var pvpu_con_tax = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["PVPU_CON_TAX"].Value;
                var pvpu_sin_tax = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["PVPU_SIN_TAX"].Value;
                var por_impto = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["POR_IMPTO"].Value;
                var id_um = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["UM"].Value;

                if (pvpu_con_tax == null) prod.mto_pvpu_con_tax = null; else prod.mto_pvpu_con_tax = decimal.Parse(pvpu_con_tax.ToString());
                if (pvpu_sin_tax == null) prod.mto_pvpu_sin_tax = null; else prod.mto_pvpu_sin_tax = decimal.Parse(pvpu_sin_tax.ToString());
                if (por_impto == null) prod.por_impto = 0; else prod.por_impto = decimal.Parse(por_impto.ToString());
                if (id_um == null) prod.id_um = null; else prod.id_um = int.Parse(id_um.ToString());

                return prod;
            }
            catch (Exception)
            {
                Msg.Ok_Err("No se pudo obtener el producto.", "Excepción encontrada");
            }
            return null;
        }

        private void SeleccionarProducto(DataGridViewCellEventArgs e = null)
        {
            if (e != null && e.RowIndex == -1 || !(dgvProd.SelectedRows.Count > 0)) return;

            if (dgvProd.CurrentRow != null)
            {
                try
                {
                    var estado = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
                    var desc = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();

                    if (estado == Estado.TxtActivo)
                    {
                        producto = GetProducto();
                        CerrarForm();
                    }
                    else
                    {
                        if (DialogResult.OK == Msg.OkCancel_Info($@"No puede seleccionar el producto '{desc}' porque NO ESTÁ ACTIVADO. ¿Desea activarlo y seleccionarlo?."))
                        {
                            if (long.TryParse(ControlHelper.DgvGetCellValueSelected(dgvProd, 0), out long id))
                            {
                                if (new ProductoBL().ActivarProducto(id))
                                {
                                    producto = GetProducto();
                                    if (producto != null)
                                    {
                                        producto.id_estado = Estado.IdActivo;
                                        producto.txt_estado = Estado.TxtActivo;
                                    }
                                    CerrarForm();
                                }
                                else
                                    Msg.Ok_Err($"No se pudo activar el producto '{desc}'.");
                            }
                            else
                                Msg.Ok_Err($"No se pudo activar el producto '{desc}'.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    producto = null;
                    MessageBox.Show($"No se pudo seleccionar el producto. Excepción: {ex.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CerrarForm()
        {
            Hide();
            Close();
        }


        #endregion

        #region Eventos

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            SetInicio();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void txtCodigo02_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void txtDescripcionProd_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void dgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProducto(e);
        }

        private void chkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void chkProdVenta_CheckedChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void chkProdCompra_CheckedChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarProducto();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            BuscarProducto(true);
        }

        private void dgvProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarProducto();
            }
        }

        private void dgvProd_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e);
        }

        #endregion

    }
}
