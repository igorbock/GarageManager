namespace GarageManagerRazorLib.Interfaces;

public interface IPage<TipoT>
{
    Task Salvar();
    Task Editar(TipoT entidade);
    Task Apagar(TipoT entidade);
}

