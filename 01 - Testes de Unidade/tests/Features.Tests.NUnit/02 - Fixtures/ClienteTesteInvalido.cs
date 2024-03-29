namespace Features.Tests.NUnit;

public class ClienteTesteInvalido
{
    private ClienteTestsFixture _clienteTestsFixture;

    [SetUp]
    public void Init()
    {
        _clienteTestsFixture = new();
    }

    [TestCase(TestName = "Novo Cliente Inválido")]
    [Category("Categoria"), Description("Cliente Trait Testes")]
    public void Cliente_NovoCliente_DeveEstarInvalido()
    {
        // Arrange
        var cliente = _clienteTestsFixture.GerarClienteInValido();

        // Act
        var result = cliente.EhValido();

        // Assert 
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.False);
            Assert.That(cliente.ValidationResult.Errors, Is.Not.Empty);
        });
    }
}