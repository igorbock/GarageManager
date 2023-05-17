﻿using GarageManagerRazorLib.Models;

namespace GarageManagerRazorLib.Services;

public class ClienteService : ServiceAbstract<Cliente>
{
    public ClienteService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public override async Task<int> Atualizar(Cliente p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public override async Task<int> Criar(Cliente p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public override async Task<int> Excluir(int p_codigo) => await EnviarParaWS(_endpoint, p_codigo);

    public override async Task<IEnumerable<Cliente>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}