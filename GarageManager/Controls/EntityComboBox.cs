using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GarageManager.Controls
{
    public partial class EntityComboBox : UserControl
    {
        public event EventHandler SelectedIndexChanged;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action ReloadAction { get; set; }

        [Category("Appearance")]
        [DefaultValue("Entidade")]
        [Description("Texto exibido no label da entidade")]
        public string LabelText
        {
            get => labelEntidade?.Text ?? "Entidade";
            set { if (labelEntidade != null) labelEntidade.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedValue
        {
            get
            {
                if (comboBoxEntidade.SelectedValue is int id)
                    return id;
                return -1;
            }
            set => comboBoxEntidade.SelectedValue = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem => comboBoxEntidade.SelectedItem;

        public EntityComboBox()
        {
            InitializeComponent();
            btnAbrir.Click += BtnAbrir_Click;
            comboBoxEntidade.SelectedIndexChanged += (s, e) =>
                SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            ReloadAction?.Invoke();
        }

        public void Reload()
        {
            var selecionado = comboBoxEntidade.SelectedValue;
            comboBoxEntidade.DataSource = null;
            comboBoxEntidade.BindingContext = new BindingContext();
            if (selecionado != null)
                comboBoxEntidade.SelectedValue = selecionado;
        }

        public void Reload<T>(List<T> dataSource) where T : class
        {
            var selecionado = comboBoxEntidade.SelectedValue;
            comboBoxEntidade.DataSource = null;
            comboBoxEntidade.BindingContext = new BindingContext();
            comboBoxEntidade.ValueMember = "Id";
            comboBoxEntidade.DataSource = dataSource;
            if (selecionado != null)
                comboBoxEntidade.SelectedValue = selecionado;
            else
                comboBoxEntidade.SelectedIndex = -1;
        }

        public void Clear()
        {
            comboBoxEntidade.SelectedIndex = -1;
        }
    }
}
