using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista() //Example, not made by me. Name: Should remove the negative numbers from a list
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };
        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista() //Example, not made by me. Name: It should find the number 9 on the list
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;
        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista() //Shouldn't find 10 in the list
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;
        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2() //Should multiply the entire list by 2
    {
        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista() //Should find 9 as the highest value in the list
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista() //Should find -8 as the lowest value in the list
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);
        // Assert
        Assert.Equal(-8, resultado);
    }
}
