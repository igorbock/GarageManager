using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadServico : FrmCadBase<Servico>
    {
        public FrmCadServico() : base(new Repository<Servico>(), "Cadastro de Serviços")
        {
        }
    }
}
