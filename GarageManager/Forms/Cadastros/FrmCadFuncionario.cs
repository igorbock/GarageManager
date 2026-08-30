using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadFuncionario : FrmCadBase<Funcionario>
    {
        public FrmCadFuncionario() : base(new Repository<Funcionario>(), "Cadastro de Funcionários")
        {
        }
    }
}
