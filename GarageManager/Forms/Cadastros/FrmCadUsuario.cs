using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadUsuario : FrmCadBase<Usuario>
    {
        public FrmCadUsuario() : base(new Repository<Usuario>(), "Cadastro de Usuários")
        {
        }
    }
}
