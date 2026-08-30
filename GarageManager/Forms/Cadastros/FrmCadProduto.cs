using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms.Cadastros
{
    public class FrmCadProduto : FrmCadBase<Produto>
    {
        public FrmCadProduto() : base(new Repository<Produto>(), "Cadastro de Produtos")
        {
        }
    }
}
