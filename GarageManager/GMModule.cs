using GarageManager.Forms.Cadastro;
using Ninject.Modules;
using System.Windows.Forms;

namespace GarageManager;

public class GMModule : NinjectModule
{
    public override void Load()
    {
        Bind<Form>().To<FrmCadMarca>().Named(nameof(FrmCadMarca));
        Bind<Form>().To<FrmCadMarca2>().Named(nameof(FrmCadMarca2));
        Bind<Form>().To<FrmCadModelo>().Named(nameof(FrmCadModelo));
        Bind<Form>().To<FrmCadPessoa>().Named(nameof(FrmCadPessoa));
    }
}
