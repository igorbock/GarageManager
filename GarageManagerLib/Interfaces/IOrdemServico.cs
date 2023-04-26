namespace GarageManagerLib.Interfaces;

public interface IOrdemServico
{
    ActionResult CreateOrdemServico(OrdemServico p_ordemServico);
    ActionResult ReadOrdemServico(int? p_ordemServico);
    ActionResult UpdateOrdemServico(OrdemServico p_ordemServico);
    ActionResult DeleteOrdemServico(OrdemServico p_ordemServico);
}
