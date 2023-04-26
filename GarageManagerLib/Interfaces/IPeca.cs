namespace GarageManagerLib.Interfaces;

public interface IPeca
{
    ActionResult CreatePeca(Peca p_peca);
    ActionResult ReadPeca(int? p_peca);
    ActionResult UpdatePeca(Peca p_peca);
    ActionResult DeletePeca(Peca p_peca);
}
