namespace GarageManagerRazorLib.Interfaces;

public interface IModelo
{
    IGMActionResult CreateModelo(Modelo p_modelo);
    IGMActionResult ReadModelo(int? p_modelo);
    IGMActionResult UpdateModelo(Modelo p_modelo);
    IGMActionResult DeleteModelo(int p_codigo);
}
