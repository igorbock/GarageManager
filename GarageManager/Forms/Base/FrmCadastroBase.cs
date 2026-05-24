using System;
using System.Windows.Forms;
using Dominio.Interfaces;

namespace GarageManager.Forms.Base;

public partial class FrmCadastroBase : Form, IFormCadastro
{
    public FrmCadastroBase()
    {
        InitializeComponent();

        BtnInserir.Click += (s, e) => Inserir();
        BtnEditar.Click += (s, e) => Editar();
        BtnExcluir.Click += (s, e) => Excluir();
        BtnFechar.Click += (s, e) => Fechar();
        BtnSalvar.Click += (s, e) => Salvar();
        BtnCancelar.Click += (s, e) => Cancelar();
        BtnImprimirGrid.Click += (s, e) => ImprimirGrid();
    }

    public void Inserir()
    {
        throw new NotImplementedException();
    }

    public void Editar()
    {
        throw new NotImplementedException();
    }

    public void Excluir()
    {
        throw new NotImplementedException();
    }

    public void Fechar()
    {
        throw new NotImplementedException();
    }

    public void Salvar()
    {
        throw new NotImplementedException();
    }

    public void Cancelar()
    {
        throw new NotImplementedException();
    }

    public void ImprimirGrid()
    {
        throw new NotImplementedException();
    }
}
