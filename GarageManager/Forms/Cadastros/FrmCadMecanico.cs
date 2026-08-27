using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadMecanico : FrmCadBase<Mecanico>
    {
        public FrmCadMecanico() : base(new Repository<Mecanico>(), "Cadastro de Mecânicos")
        {
        }
    }
}
