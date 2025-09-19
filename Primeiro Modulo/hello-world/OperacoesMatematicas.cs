using System;

namespace hello_world;

public class OperacoesMatematicas
{
    //Quando uma funcao nao depende de nenhum valor da instancia da classe, ela pode ser static (esse poderia ser mas nao vou mudar para evitar erros antigos, exemplo na proxima funcao)
    public int Adicionar(int valor1, int valor2)
    {
        int resultado = valor1 + valor2;

        return resultado;
    }

    public static int Subtrair(int valor1, int valor2) // exemplo de static
    {
        return valor1 - valor2;
    }

    public (int resultadoDaAdicao, string nomeDaFuncao) RetornandoDoisValores(int valor1, int valor2) //definindo mais de um retorno e dando nome a eles
    {
        int resultado = valor1 + valor2;
        string nomeDaFuncao = "RetornandoDoisValores";

        return (resultado, nomeDaFuncao);
    }

    public void Teste(int valor1, int valor2 = 0) //Ao dar um valor inicial pro parametro ele vira opcional na hora de invocar a função, ja que ele tem um valor inicial
    {
        Console.WriteLine($"Função teste: {valor1} + {valor2} = {valor1 + valor2}");
    }
}
