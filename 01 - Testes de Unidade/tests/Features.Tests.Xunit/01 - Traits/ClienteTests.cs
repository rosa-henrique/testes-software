﻿using Features.Clientes;

namespace Features.Tests.Xunit;

public class ClienteTests
{
    [Fact(DisplayName = "Novo Cliente Válido")]
    [Trait("Categoria","Cliente Trait Testes")]
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
        Assert.True(result);
        Assert.Empty(cliente.ValidationResult.Errors);
    }

    [Fact(DisplayName = "Novo Cliente Inválido")]
    [Trait("Categoria", "Cliente Trait Testes")]
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
        Assert.False(result);
        Assert.NotEmpty(cliente.ValidationResult.Errors);
    }
}