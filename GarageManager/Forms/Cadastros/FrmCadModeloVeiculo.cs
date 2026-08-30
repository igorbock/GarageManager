using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadModeloVeiculo : FrmCadBase<ModeloVeiculo>
    {
        public FrmCadModeloVeiculo() : base(new Repository<ModeloVeiculo>(), "Cadastro de Modelos de Veículo")
        {
        }
    }
}
