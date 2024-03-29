namespace Demo.Tests.NUnit;

public class AssertNullBoolTests
{
    [Test]
    public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
    {
        // Arrange & Act
        var funcionario = new Funcionario("", 1000);

        // Assert
        Assert.That(string.IsNullOrEmpty(funcionario.Nome), Is.False);
    }

    [Test]
    public void Funcionario_Apelido_NaoDeveTerApelido()
    {
        // Arrange & Act
        var funcionario = new Funcionario("Eduardo", 1000);

        Assert.Multiple(() =>
        {

            //Assert
            Assert.That(funcionario.Apelido, Is.Null);

            // Assert Bool
            Assert.That(string.IsNullOrEmpty(funcionario.Apelido), Is.True);
            Assert.That(funcionario.Apelido?.Length > 0, Is.False);
        });
    }
}
