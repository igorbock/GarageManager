namespace GarageManagerRazorLib.Interfaces;

public interface IVeiculo
{
    IGMActionResult CreateVeiculo(Veiculo p_veiculo);
    IGMActionResult ReadVeiculo(int? p_veiculo);
    IGMActionResult UpdateVeiculo(Veiculo p_veiculo);
    IGMActionResult DeleteVeiculo(int p_codigo);
}
