namespace GarageManagerLib.Interfaces;

public interface IMarca
{
    ActionResult CreateMarca(Marca p_marca);
    ActionResult ReadMarca(int? p_marca);
    ActionResult UpdateMarca(Marca p_marca);
    ActionResult DeleteMarca(Marca p_marca);
}
