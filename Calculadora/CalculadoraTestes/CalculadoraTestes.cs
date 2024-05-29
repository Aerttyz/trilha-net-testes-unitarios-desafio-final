using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calculadora;

    public CalculadoraTests()
    {
        _calculadora = new CalculadoraImp();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void DeveExecutarSoma(int num1, int num2, int resultado)
    {
        Assert.Equal(resultado, _calculadora.Somar(num1, num2));
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 5, -1)]
    public void DeveExecutarSubtracao(int num1, int num2, int resultado)
    {
        Assert.Equal(resultado, _calculadora.Subtrair(num1, num2));
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void DeveExecutarMultiplicacao(int num1, int num2, int resultado)
    {
        Assert.Equal(resultado, _calculadora.Multiplicar(num1, num2));
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(10, 5, 2)]
    public void DeveExecutarDivisao(int num1, int num2, int resultado)
    {
        Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(num1, 0));
        Assert.Equal(resultado, _calculadora.Dividir(num1, num2));
    }

    [Fact]
    public void DeveRetornarHistorico()
    {
        _calculadora.Somar(1, 2);
        _calculadora.Subtrair(1, 2);
        _calculadora.Multiplicar(1, 2);

        var lista   = _calculadora.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
