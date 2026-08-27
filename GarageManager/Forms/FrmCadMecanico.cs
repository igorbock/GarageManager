using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public class FrmCadMecanico : FrmCadBase<Mecanico>
    {
        public FrmCadMecanico() : base(new Repository<Mecanico>(), "Cadastro de Mecânicos")
        {
        }
    }
}
