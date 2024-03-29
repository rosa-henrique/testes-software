namespace Features.Tests.NUnit;

public class ClienteTesteValido
{
    private ClienteTestsFixture _clienteTestsFixture;

    [SetUp]
    public void Init()
    {
        _clienteTestsFixture = new();
    }


    [TestCase(TestName = "Novo Cliente Válido")]
    [Category("Categoria"), Description("Cliente Trait Testes")]
    public void Cliente_NovoCliente_DeveEstarValido()
    {
        // Arrange
        var cliente = _clienteTestsFixture.GerarClienteValido();

        // Act
        var result = cliente.EhValido();

        // Assert 
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.True);
            Assert.That(cliente.ValidationResult.Errors, Is.Empty);
        });
    }
}