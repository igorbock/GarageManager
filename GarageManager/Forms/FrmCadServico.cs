using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public class FrmCadServico : FrmCadBase<Servico>
    {
        public FrmCadServico() : base(new Repository<Servico>(), "Cadastro de Serviços")
        {
        }
    }
}
