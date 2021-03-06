﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FrmBUSCARAFILIADO : Form
    {
        MODELO.AFILIADO oAFILIADO;
        CONTROLADORA.cAFILIADOS cAFILIADOS;
        public FrmBUSCARAFILIADO()
        {
            InitializeComponent();
            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();

            if (cAFILIADOS.Obtener_Afiliado(string.Empty).Count > 0)
                ARMAR_GRILLA();
        }

        private void ARMAR_GRILLA()
        {
            dgvAFILIADOS.DataSource = null;
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliado(string.Empty);

            dgvAFILIADOS.Columns[2].Visible = false;
            dgvAFILIADOS.Columns[3].Visible = false;
            dgvAFILIADOS.Columns[4].Visible = false;
            dgvAFILIADOS.Columns[7].Visible = false;
            dgvAFILIADOS.Columns[13].Visible = false;
            dgvAFILIADOS.Columns[12].Visible = false;

            dgvAFILIADOS.Columns[0].HeaderText = "ID_AFILIADO";
            dgvAFILIADOS.Columns[1].HeaderText = "NOMBRE";
            dgvAFILIADOS.Columns[5].HeaderText = "DNI";
            dgvAFILIADOS.Columns[6].HeaderText = "NACIMIENTO";
            dgvAFILIADOS.Columns[8].HeaderText = "TITULAR";
            dgvAFILIADOS.Columns[9].HeaderText = "ADHERENTE";
            dgvAFILIADOS.Columns[10].HeaderText = "CONTRATO";
            dgvAFILIADOS.Columns[11].HeaderText = "ESTADO";
        }

        public MODELO.AFILIADO AFILIADO
        {
            get
            {
                return oAFILIADO;
            }
        }

        private void dgvAFILIADOS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAFILIADOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Afiliafo");
                return;
            }
            else
            {
                oAFILIADO = (MODELO.AFILIADO)dgvAFILIADOS.CurrentRow.DataBoundItem;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void txtNombre_Afiliado_KeyUp(object sender, KeyEventArgs e)
        {
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliado(txtNombre_Afiliado.Text);
        }

        private void txtNombre_Afiliado_TextChanged(object sender, EventArgs e)
        {
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliado(txtNombre_Afiliado.Text);

            dgvAFILIADOS.Columns[2].Visible = false;
            dgvAFILIADOS.Columns[3].Visible = false;
            dgvAFILIADOS.Columns[4].Visible = false;
            dgvAFILIADOS.Columns[7].Visible = false;
            dgvAFILIADOS.Columns[13].Visible = false;
            dgvAFILIADOS.Columns[12].Visible = false;

            dgvAFILIADOS.Columns[0].HeaderText = "ID_AFILIADO";
            dgvAFILIADOS.Columns[1].HeaderText = "NOMBRE";
            dgvAFILIADOS.Columns[5].HeaderText = "DNI";
            dgvAFILIADOS.Columns[6].HeaderText = "NACIMIENTO";
            dgvAFILIADOS.Columns[8].HeaderText = "TITULAR";
            dgvAFILIADOS.Columns[9].HeaderText = "ADHERENTE";
            dgvAFILIADOS.Columns[10].HeaderText = "CONTRATO";
            dgvAFILIADOS.Columns[11].HeaderText = "ESTADO";
        }
    }
}
