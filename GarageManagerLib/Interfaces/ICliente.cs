namespace GarageManagerLib.Interfaces;

public interface ICliente
{
    ActionResult CreateCliente(Cliente p_cliente);
    ActionResult ReadCliente(int? p_cliente);
    ActionResult UpdateCliente(Cliente p_cliente);
    ActionResult DeleteCliente(Cliente p_cliente);
}
