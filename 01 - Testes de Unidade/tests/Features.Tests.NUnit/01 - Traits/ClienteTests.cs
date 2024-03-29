using Features.Clientes;

namespace Features.Tests.NUnit;

public class ClienteTests
{
    [TestCase(TestName = "Novo Cliente Válido")]
    [Category("Categoria"), Description("Cliente Trait Testes")]
    public void Cliente_NovoCliente_DeveEstarValido()
    {
        // Arrange
        var cliente = new Cliente(
            Guid.NewGuid(),
            "Eduardo",
            "Pires",
            DateTime.Now.AddYears(-30),
            "edu@edu.com",
            true,
            DateTime.Now);

        // Act
        var result = cliente.EhValido();

        // Assert 
        Assert.That(result, Is.True);
        Assert.That(cliente.ValidationResult.Errors, Is.Empty);
    }

    [TestCase(TestName = "Novo Cliente Inválido")]
    [Category("Categoria"), Description("Cliente Trait Testes")]
    public void Cliente_NovoCliente_DeveEstarInvalido()
    {
        // Arrange
        var cliente = new Cliente(
            Guid.NewGuid(),
            "",
            "",
            DateTime.Now,
            "edu2edu.com",
            true,
            DateTime.Now);

        // Act
        var result = cliente.EhValido();

        // Assert 
        Assert.That(result, Is.False);
        Assert.That(cliente.ValidationResult.Errors, Is.Not.Empty);
    }
}