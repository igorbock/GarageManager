using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadPessoa : FrmCadBase<Pessoa>
    {
        public FrmCadPessoa() : base(new Repository<Pessoa>(), "Cadastro de Pessoas")
        {
        }
    }
}
