namespace GarageManagerLib.Interfaces;

public interface IModelo
{
    ActionResult CreateModelo(Modelo p_modelo);
    ActionResult ReadModelo(int? p_modelo);
    ActionResult UpdateModelo(Modelo p_modelo);
    ActionResult DeleteModelo(int p_codigo);
}
