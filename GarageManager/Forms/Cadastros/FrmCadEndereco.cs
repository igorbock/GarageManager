using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadEndereco : FrmCadBase<Endereco>
    {
        public FrmCadEndereco() : base(new Repository<Endereco>(), "Cadastro de Endereços")
        {
        }
    }
}
