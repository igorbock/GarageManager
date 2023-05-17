﻿using GarageManagerRazorLib.Models;

namespace GarageManagerRazorLib.Services;

public class OrdemServicoPecasService : ServiceAbstract<OrdemServicoPecas>
{
    public OrdemServicoPecasService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public override async Task<int> Atualizar(OrdemServicoPecas p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public override async Task<int> Criar(OrdemServicoPecas p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public override async Task<int> Excluir(int p_codigo) => await EnviarParaWS(_endpoint, p_codigo);

    public override async Task<IEnumerable<OrdemServicoPecas>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
