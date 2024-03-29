namespace Demo.Tests.NUnit;

public class AssertingObjectTypesTests
{
    [Test]
    public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);

        // Assert
        Assert.That(funcionario, Is.TypeOf<Funcionario>());
    }

    [Test]
    public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);

        // Assert
        Assert.That(funcionario, Is.InstanceOf<Pessoa>());
    }
}
