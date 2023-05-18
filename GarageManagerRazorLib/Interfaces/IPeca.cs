namespace GarageManagerRazorLib.Interfaces;

public interface IPeca
{
    IGMActionResult CreatePeca(Peca p_peca);
    IGMActionResult ReadPeca(int? p_peca);
    IGMActionResult UpdatePeca(Peca p_peca);
    IGMActionResult DeletePeca(Peca p_peca);
}
