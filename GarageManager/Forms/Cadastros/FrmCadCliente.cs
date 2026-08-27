using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadCliente : FrmCadBase<Cliente>
    {
        public FrmCadCliente() : base(new Repository<Cliente>(), "Cadastro de Clientes")
        {
        }
    }
}
