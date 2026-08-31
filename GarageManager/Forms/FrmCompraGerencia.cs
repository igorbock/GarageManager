using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmCompraGerencia : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Home MainForm { get; set; }

        public FrmCompraGerencia(Home main)
        {
            MainForm = main;
            InitializeComponent();
            comboStatus.SelectedIndex = 0;
        }

        private void FrmCompraGerencia_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void Dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv.IsCurrentCellDirty && dgv.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ComboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var f = new FrmCompra { IdCompra = 0 };
            f.ShowDialog();
            CarregarGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarGrid()
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            string filtro = comboStatus.SelectedItem?.ToString();
            string where = "";
            var param = new DynamicParameters();
            param.Add("eid", Sessao.EmpresaId ?? 1);
            if (filtro != null && filtro != "Todas")
            {
                where = " AND c.status=@st ";
                param.Add("st", filtro);
            }
            using (var conn = GarageDb.OpenConnection())
            {
                var dados = conn.Query(
                    @"SELECT c.id AS Id, c.data AS Data, COALESCE(p.nome,'Avulso') AS Fornecedor, c.total AS Total, c.status AS Status, c.observacao AS Observacao
                      FROM compra c LEFT JOIN pessoa p ON p.id=c.id_fornecedor
                      WHERE c.id_empresa=@eid " + where + " ORDER BY c.id DESC", param).ToList();
                dgv.DataSource = dados;
            }
            if (dgv.Columns.Count >= 6)
            {
                var check = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionar",
                    HeaderText = "",
                    Width = 40,
                    FalseValue = false,
                    ReadOnly = false
                };
                dgv.Columns.Insert(0, check);
                if (dgv.Columns["Id"] != null) dgv.Columns["Id"].Visible = false;
                if (dgv.Columns["Data"] != null) dgv.Columns["Data"].Width = 140;
                if (dgv.Columns["Fornecedor"] != null) dgv.Columns["Fornecedor"].Width = 150;
                if (dgv.Columns["Total"] != null) dgv.Columns["Total"].Width = 80;
                if (dgv.Columns["Status"] != null) dgv.Columns["Status"].Width = 90;
                if (dgv.Columns["Observacao"] != null) dgv.Columns["Observacao"].Width = 200;
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col is DataGridViewCheckBoxColumn) continue;
                    col.ReadOnly = true;
                }
            }
        }

        private void Editar()
        {
            var selecionados = ObterIdsSelecionados();
            if (selecionados.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selecionados.Count > 1)
            {
                MessageBox.Show("Selecione somente 1 registro.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var frm = new FrmCompra { IdCompra = selecionados[0] };
            frm.ShowDialog();
            CarregarGrid();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterIdsSelecionados();
            if (selecionados.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selecionados.Count > 1)
            {
                MessageBox.Show("Selecione somente 1 registro.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = selecionados[0];
            var repo = new Repository<Compra>();
            var c = repo.GetById(id);
            if (c == null) return;
            if (c.Status == "FECHADA" || c.Status == "CANCELADA")
            {
                MessageBox.Show("Compra fechada/cancelada não pode ser excluída. Use CANCELADA para estornar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Excluir compra #" + id + "?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var repoItem = new Repository<CompraItem>();
            var itens = repoItem.GetAll().Where(x => x.IdCompra == id).ToList();
            foreach (var it in itens) repoItem.Delete(it.Id);
            repo.Delete(id);
            MessageBox.Show("Compra excluída.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
        }

        private List<int> ObterIdsSelecionados()
        {
            var ids = new List<int>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                {
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                }
            }
            return ids;
        }
    }
}
