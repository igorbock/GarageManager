using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadMarca : FrmCadBase<Marca>
    {
        public FrmCadMarca() : base(new Repository<Marca>(), "Cadastro de Marcas")
        {
        }
    }
}
