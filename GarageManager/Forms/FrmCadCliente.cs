using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public class FrmCadCliente : FrmCadBase<Cliente>
    {
        public FrmCadCliente() : base(new Repository<Cliente>(), "Cadastro de Clientes")
        {
        }
    }
}
