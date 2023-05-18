namespace GarageManagerRazorLib.Interfaces;

public interface IOrdemServico
{
    IGMActionResult CreateOrdemServico(OrdemServico p_ordemServico);
    IGMActionResult ReadOrdemServico(int? p_ordemServico);
    IGMActionResult UpdateOrdemServico(OrdemServico p_ordemServico);
    IGMActionResult DeleteOrdemServico(OrdemServico p_ordemServico);
}
