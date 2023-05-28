namespace GarageManagerRazorLib.Interfaces;

public interface IControllerCRUD<TipoT>
{
    IGMActionResult Save(TipoT entidade);
    IGMActionResult Read(int? codigo);
    IGMActionResult Delete(int codigo);
}
