namespace GarageManagerLib.Interfaces;

public interface IVeiculo
{
    ActionResult CreateVeiculo(Veiculo p_veiculo);
    ActionResult ReadVeiculo(int? p_veiculo);
    ActionResult UpdateVeiculo(Veiculo p_veiculo);
    ActionResult DeleteVeiculo(int p_codigo);
}
