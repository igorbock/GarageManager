using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadCidade : FrmCadBase<Cidade>
    {
        public FrmCadCidade() : base(new Repository<Cidade>(), "Cadastro de Cidades")
        {
        }
    }
}
