using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadEmpresa : FrmCadBase<Empresa>
    {
        public FrmCadEmpresa() : base(new Repository<Empresa>(), "Cadastro de Empresas")
        {
        }
    }
}
