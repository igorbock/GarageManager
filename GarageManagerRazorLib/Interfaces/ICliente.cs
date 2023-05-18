namespace GarageManagerRazorLib.Interfaces;

public interface ICliente
{
    IGMActionResult CreateCliente(Cliente p_cliente);
    IGMActionResult ReadCliente(int? p_cliente);
    IGMActionResult UpdateCliente(Cliente p_cliente);
    IGMActionResult DeleteCliente(Cliente p_cliente);
}
