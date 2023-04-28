namespace GarageManagerTeste.Controllers;

public class OrdemServicoControllerTest
{
    private Mock<GarageManagerAPI.Context.Modelo>? _modeloMock { get; set; }
    private OrdemServicoController? _ordemServicoControllerMock { get; set; }
    private Mock<DbSet<OrdemServico>>? _ordemServicoMock { get; set; }
    private ControllerContext? _controllerContextGET { get; set; }
    private ControllerContext? _controllerContextPOST { get; set; }
    private ControllerContext? _controllerContextPUT { get; set; }
    private ControllerContext? _controllerContextDELETE { get; set; }

    private void SetUp()
    {
        var requestGET = new Mock<HttpRequest>();
        requestGET.Setup(x => x.Method).Returns("GET");
        var httpContextGET = Mock.Of<HttpContext>(a => a.Request == requestGET.Object);
        _controllerContextGET = new ControllerContext() { HttpContext = httpContextGET };

        var requestPOST = new Mock<HttpRequest>();
        requestPOST.Setup(x => x.Method).Returns("POST");
        var httpContextPOST = Mock.Of<HttpContext>(a => a.Request == requestPOST.Object);
        _controllerContextPOST = new ControllerContext() { HttpContext = httpContextPOST };

        var requestPUT = new Mock<HttpRequest>();
        requestPUT.Setup(x => x.Method).Returns("PUT");
        var httpContextPUT = Mock.Of<HttpContext>(a => a.Request == requestPUT.Object);
        _controllerContextPUT = new ControllerContext() { HttpContext = httpContextPUT };

        var requestDELETE = new Mock<HttpRequest>();
        requestDELETE.Setup(x => x.Method).Returns("DELETE");
        var httpContextDELETE = Mock.Of<HttpContext>(a => a.Request == requestDELETE.Object);
        _controllerContextDELETE = new ControllerContext() { HttpContext = httpContextDELETE };

        var fonteDadosOrdensServico = new List<OrdemServico>
        {
            new OrdemServico { Id = 1, Inicio = new DateTime(2023,04,27,23,12,00), Fim = new DateTime(2023,04,27,23,46,00) },
            new OrdemServico { Id = 2, Inicio = new DateTime(2023,04,27,23,47,24), Fim = new DateTime(2023,04,27,23,49,13) }
        }.AsQueryable();
        _ordemServicoMock = new Mock<DbSet<OrdemServico>>();
        _ordemServicoMock.As<IQueryable<OrdemServico>>().Setup(s => s.Provider).Returns(fonteDadosOrdensServico.Provider);
        _ordemServicoMock.As<IQueryable<OrdemServico>>().Setup(s => s.Expression).Returns(fonteDadosOrdensServico.Expression);
        _ordemServicoMock.As<IQueryable<OrdemServico>>().Setup(s => s.ElementType).Returns(fonteDadosOrdensServico.ElementType);
        _ordemServicoMock.As<IQueryable<OrdemServico>>().Setup(s => s.GetEnumerator()).Returns(fonteDadosOrdensServico.GetEnumerator);

        _modeloMock = new Mock<GarageManagerAPI.Context.Modelo>();
        _modeloMock.Object.OrdensServico = _ordemServicoMock.Object;
        _modeloMock.Setup(a => a.SaveChanges()).Returns(null);
    }

    [Fact]
    public void GetOrdensServicoTest()
    {
        SetUp();

        try
        {
            _ordemServicoControllerMock = new OrdemServicoController(null, _modeloMock?.Object)
            {
                ControllerContext = _controllerContextGET ?? throw new Exception($"{nameof(_controllerContextGET)} � null")
            };

            var resultado = _ordemServicoControllerMock.ReadOrdemServico(null);
            var jsonResult = resultado as JsonResult;
            if (jsonResult is null)
                Assert.Fail("JsonResult � null");

            var json = JsonSerializer.Serialize(jsonResult.Value);
            if (string.IsNullOrWhiteSpace(json))
                Assert.Fail("Json � null");

            var ordensServico = JsonSerializer.Deserialize<IEnumerable<OrdemServico>>(json);
            if (ordensServico is null)
                Assert.Fail($"{nameof(ordensServico)} � null");
            Assert.True(ordensServico.Any());
            Assert.True(ordensServico.Count() == 2);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }

    [Fact]
    public void GetOrdemServicoTest()
    {
        SetUp();

        try
        {
            _ordemServicoControllerMock = new OrdemServicoController(null, _modeloMock?.Object)
            {
                ControllerContext = _controllerContextGET ?? throw new Exception($"{nameof(_controllerContextGET)} � null")
            };

            var resultado = _ordemServicoControllerMock.ReadOrdemServico(1);
            var jsonResult = resultado as JsonResult;
            if (jsonResult is null)
                Assert.Fail("JsonResult � null");

            var json = JsonSerializer.Serialize(jsonResult.Value);
            if (string.IsNullOrWhiteSpace(json))
                Assert.Fail("Json � null");

            var ordensServico = JsonSerializer.Deserialize<IEnumerable<OrdemServico>>(json);
            if (ordensServico is null)
                Assert.Fail($"{nameof(ordensServico)} � null");
            Assert.True(ordensServico.Any());
            Assert.True(ordensServico.Count() == 1);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }
}