namespace Demo.Tests.NUnit;

public class AssertStringsTests
{
    [Test]
    public void StringsTools_UnirNomes_RetornarNomeCompleto()
    {
        // Arrange
        var sut = new StringsTools();

        // Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");

        // Assert
        Assert.That(nomeCompleto, Is.EqualTo("Eduardo Pires"));
    }



    [Test]
    public void StringsTools_UnirNomes_DeveIgnorarCase()
    {
        // Arrange
        var sut = new StringsTools();

        // Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");

        // Assert
        StringAssert.AreEqualIgnoringCase("EDUARDO PIRES", nomeCompleto);
    }



    [Test]
    public void StringsTools_UnirNomes_DeveConterTrecho()
    {
        // Arrange
        var sut = new StringsTools();

        // Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");

        // Assert
        StringAssert.Contains("ardo", nomeCompleto);
    }


    [Test]
    public void StringsTools_UnirNomes_DeveComecarCom()
    {
        // Arrange
        var sut = new StringsTools();

        // Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");

        // Assert
        StringAssert.StartsWith("Edu", nomeCompleto);
    }


    [Test]
    public void StringsTools_UnirNomes_DeveAcabarCom()
    {
        // Arrange
        var sut = new StringsTools();

        // Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");

        // Assert
        StringAssert.EndsWith("res", nomeCompleto);
    }


    [Test]
    public void StringsTools_UnirNomes_ValidarExpressaoRegular()
    {
        // Arrange
        var sut = new StringsTools();

        // Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");

        // Assert
        StringAssert.IsMatch("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
    }
}

