namespace Demo.Tests.NUnit;

public class CalculadoraTests
{
    [Test]
    public void Calculadora_Somar_RetornarValorSoma()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Somar(2, 2);

        // Assert
        Assert.That(resultado, Is.EqualTo(4));
    }

    [TestCase(1, 1, 2)]
    [TestCase(2, 2, 4)]
    [TestCase(4, 2, 6)]
    [TestCase(7, 3, 10)]
    [TestCase(6, 6, 12)]
    [TestCase(9, 9, 18)]
    public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Somar(v1, v2);

        // Assert
        Assert.That(total, Is.EqualTo(resultado));
    }

}
