namespace Demo.Tests.NUnit;

public class AssertNumbersTests
{
    [Test]
    public void Calculadora_Somar_DeveSerIgual()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var result = calculadora.Somar(1, 2);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Calculadora_Somar_NaoDeveSerIgual()
    {
        // Arrange
        var calculadora = new Calculadora();
        var valorEsperado = 3.3;

        // Act
        var result = calculadora.Somar(1.13123123123, 2.2312313123);

        // Assert
        Assert.That(valorEsperado, Is.EqualTo(result).Within(0.1));
    }
}
