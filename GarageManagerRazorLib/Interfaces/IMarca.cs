namespace GarageManagerRazorLib.Interfaces;

public interface IMarca
{
    IGMActionResult CreateMarca(Marca p_marca);
    IGMActionResult ReadMarca(int? p_marca);
    IGMActionResult UpdateMarca(Marca p_marca);
    IGMActionResult DeleteMarca(int p_codigo);
}
