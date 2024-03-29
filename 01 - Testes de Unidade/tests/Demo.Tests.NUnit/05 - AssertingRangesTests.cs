namespace Demo.Tests.NUnit;

public class AssertingRangesTests
{
    [TestCase(700)]
    [TestCase(1500)]
    [TestCase(2000)]
    [TestCase(7500)]
    [TestCase(8000)]
    [TestCase(15000)]
    public void Funcionario_Salario_FaixasSalariaisDevemRespeitarNivelProfissional(double salario)
    {
        // Arrange & Act
        var funcionario = new Funcionario("Eduardo", salario);

        // Assert
        if (funcionario.NivelProfissional == NivelProfissional.Junior)
            Assert.That(funcionario.Salario, Is.InRange(500, 1999));

        if (funcionario.NivelProfissional == NivelProfissional.Pleno)
            Assert.That(funcionario.Salario, Is.InRange(2000, 7999));

        if (funcionario.NivelProfissional == NivelProfissional.Senior)
            Assert.That(funcionario.Salario, Is.InRange(8000, double.MaxValue));

        Assert.That(funcionario.Salario, Is.Not.InRange(0, 499));
    }
}
