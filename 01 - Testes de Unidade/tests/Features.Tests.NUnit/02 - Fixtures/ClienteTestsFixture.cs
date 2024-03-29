using Features.Clientes;

namespace Features.Tests.NUnit;

public class ClienteTestsFixture : IDisposable
{
    public Cliente GerarClienteValido()
    {
        var cliente = new Cliente(
            Guid.NewGuid(),
            "Eduardo",
            "Pires",
            DateTime.Now.AddYears(-30),
            "edu@edu.com",
            true,
            DateTime.Now);

        return cliente;
    }

    public Cliente GerarClienteInValido()
    {
        var cliente = new Cliente(
            Guid.NewGuid(),
            "",
            "",
            DateTime.Now,
            "edu2edu.com",
            true,
            DateTime.Now);

        return cliente;
    }

    public void Dispose()
    {
    }
}