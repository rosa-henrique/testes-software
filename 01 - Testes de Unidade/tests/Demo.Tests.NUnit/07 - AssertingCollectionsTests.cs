namespace Demo.Tests.NUnit;

public class AssertingCollectionsTests
{
    [Test]
    public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);

        // Assert
        Assert.That(funcionario.Habilidades, Has.Exactly(funcionario.Habilidades.Count).Matches<string>(a => !string.IsNullOrEmpty(a)));
    }

    [Test]
    public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 1000);

        // Assert
        Assert.That(funcionario.Habilidades, Has.Some.Matches<string>( a => a == "OOP"));
    }


    [Test]
    public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 1000);

        // Assert
        Assert.That(funcionario.Habilidades, Is.Not.Contains("Microservices"));
    }


    [Test]
    public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 15000);

        var habilidadesBasicas = new[]
        {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

        // Assert
        Assert.That(funcionario.Habilidades, Is.EqualTo(habilidadesBasicas));
    }
}
