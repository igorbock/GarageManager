using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadBase<T> : Form where T : ICadastro, new()
    {
        private readonly Repository<T> _repository;
        private readonly string _titulo;
        private List<T> _registros;

        private Label label_selecao;
        private ComboBox cbxRegistros;
        private PropertyGrid propertyGrid1;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnFechar;
        private Button btnSalvar;
        private Button btnCancelar;

        public FrmCadBase(Repository<T> repository, string titulo)
        {
            _repository = repository;
            _titulo = titulo;
            InitializeComponent();
            CarregarRegistros();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            label_selecao = new Label
            {
                Text = "Selecione um registro:",
                Location = new Point(12, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
            };

            cbxRegistros = new ComboBox
            {
                Location = new Point(12, 37),
                Size = new Size(460, 23),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9F),
            };
            cbxRegistros.SelectedIndexChanged += CbxRegistros_SelectedIndexChanged;

            propertyGrid1 = new PropertyGrid
            {
                Location = new Point(12, 70),
                Size = new Size(460, 370),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                PropertySort = PropertySort.NoSort,
                ToolbarVisible = false,
                HelpVisible = true,
                Enabled = false,
            };

            int yBotoes = 450;

            btnInserir = new Button
            {
                Text = "Inserir",
                Location = new Point(12, yBotoes),
                Size = new Size(80, 30),
                Font = new Font("Segoe UI", 9F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
            };
            btnInserir.Click += BtnInserir_Click;

            btnEditar = new Button
            {
                Text = "Editar",
                Location = new Point(100, yBotoes),
                Size = new Size(80, 30),
                Font = new Font("Segoe UI", 9F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
            };
            btnEditar.Click += BtnEditar_Click;

            btnExcluir = new Button
            {
                Text = "Excluir",
                Location = new Point(188, yBotoes),
                Size = new Size(80, 30),
                Font = new Font("Segoe UI", 9F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
            };
            btnExcluir.Click += BtnExcluir_Click;

            btnFechar = new Button
            {
                Text = "Fechar",
                Location = new Point(392, yBotoes),
                Size = new Size(80, 30),
                Font = new Font("Segoe UI", 9F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
            };
            btnFechar.Click += (s, e) => Close();

            btnSalvar = new Button
            {
                Text = "Salvar",
                Location = new Point(12, yBotoes),
                Size = new Size(80, 30),
                Font = new Font("Segoe UI", 9F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Visible = false,
            };
            btnSalvar.Click += BtnSalvar_Click;

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(100, yBotoes),
                Size = new Size(80, 30),
                Font = new Font("Segoe UI", 9F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Visible = false,
            };
            btnCancelar.Click += BtnCancelar_Click;

            Controls.Add(label_selecao);
            Controls.Add(cbxRegistros);
            Controls.Add(propertyGrid1);
            Controls.Add(btnInserir);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 491);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = _titulo;

            ResumeLayout(false);
            PerformLayout();
        }

        private void CarregarRegistros()
        {
            _registros = _repository.GetAll();
            cbxRegistros.DataSource = null;
            cbxRegistros.BindingContext = new BindingContext();
            cbxRegistros.ValueMember = "Id";
            cbxRegistros.DataSource = _registros;
            cbxRegistros.SelectedIndex = -1;
            propertyGrid1.SelectedObject = null;
        }

        private void CbxRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRegistros.SelectedIndex < 0)
            {
                propertyGrid1.SelectedObject = null;
                return;
            }

            var registro = (T)cbxRegistros.SelectedItem;
            var completo = _repository.GetById(registro.Id);
            propertyGrid1.SelectedObject = new OrderedPropertyGridWrapper(completo);
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            var novo = new T();
            propertyGrid1.SelectedObject = new OrderedPropertyGridWrapper(novo);

            cbxRegistros.SelectedIndex = -1;
            propertyGrid1.Focus();
            ToggleBotoesEdicao(true);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (cbxRegistros.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um registro para editar.", "Editar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selecionado = (T)cbxRegistros.SelectedItem;
            var completo = _repository.GetById(selecionado.Id);
            propertyGrid1.SelectedObject = new OrderedPropertyGridWrapper(completo);
            propertyGrid1.Focus();
            ToggleBotoesEdicao(true);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (cbxRegistros.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selecionado = (T)cbxRegistros.SelectedItem;

            if (DialogResult.Yes != MessageBox.Show(
                $"Deseja realmente excluir \"{selecionado.DisplayText}\"?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            if (typeof(T) == typeof(Mecanico))
            {
                if (_repository.HasDependency("OrdemServico", "Mecanico", selecionado.Id))
                {
                    MessageBox.Show("Não é possível excluir: este mecânico possui ordens de serviço vinculadas.",
                        "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (typeof(T) == typeof(Cliente))
            {
                if (_repository.HasDependency("OrdemServico", "Nome_cliente", selecionado.Id))
                {
                    MessageBox.Show("Não é possível excluir: este cliente possui ordens de serviço vinculadas.",
                        "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            _repository.Delete(selecionado.Id);
            MessageBox.Show("Registro excluído com sucesso.", "Excluir",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarRegistros();
        }

        protected void ConfirmarEdicao()
        {
            var objeto = propertyGrid1.SelectedObject;
            if (objeto == null) return;

            T entidade;
            if (objeto is OrderedPropertyGridWrapper wrapper)
                entidade = (T)wrapper.GetPropertyOwner(null);
            else if (objeto is T direct)
                entidade = direct;
            else
                return;

            var erros = _repository.Validar(entidade);
            if (erros.Count > 0)
            {
                MessageBox.Show(string.Join("\n", erros), "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (entidade.Id > 0)
            {
                _repository.Update(entidade);
                MessageBox.Show("Registro atualizado com sucesso.", "Salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int novoId = _repository.Insert(entidade);
                entidade.Id = novoId;
                MessageBox.Show("Registro inserido com sucesso.", "Salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CarregarRegistros();
            ToggleBotoesEdicao(false);
        }

        private void ToggleBotoesEdicao(bool editando)
        {
            btnInserir.Visible = !editando;
            btnEditar.Visible = !editando;
            btnExcluir.Visible = !editando;
            btnFechar.Visible = !editando;
            btnSalvar.Visible = editando;
            btnCancelar.Visible = editando;
            propertyGrid1.Enabled = editando;
            cbxRegistros.Enabled = !editando;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ConfirmarEdicao();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ToggleBotoesEdicao(false);
            if (cbxRegistros.SelectedIndex >= 0)
            {
                var registro = (T)cbxRegistros.SelectedItem;
                var completo = _repository.GetById(registro.Id);
                propertyGrid1.SelectedObject = new OrderedPropertyGridWrapper(completo);
            }
            else
            {
                propertyGrid1.SelectedObject = null;
            }
        }
    }
}
