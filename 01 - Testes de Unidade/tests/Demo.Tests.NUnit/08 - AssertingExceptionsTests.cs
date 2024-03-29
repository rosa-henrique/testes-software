namespace Demo.Tests.NUnit;

public class AssertingExceptionsTests
{
    [Test]
    public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
    }


    [Test]
    public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitido()
    {
        // Arrange & Act & Assert
        var exception =
            Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Eduardo", 250))
            ;

        Assert.That(exception.Message, Is.EqualTo("Salario inferior ao permitido"));
    }
}
