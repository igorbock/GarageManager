namespace GarageManagerLib.Interfaces;

public interface IService<TipoT>
{
    Task<int> Criar(TipoT p_entidade);
    Task<IEnumerable<TipoT>> Ler(int? p_codigo);
    Task<int> Atualizar(TipoT p_entidade);
    Task<int> Excluir(int p_codigo);
}
