using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using hello_world;

namespace HelloWorld;

internal class Program
{
	enum NivelDeDificuldade
	{
		Baixo,
		Medio,
		Alto
	}

	//Em aplicações console. Ao executar ele por padrão busca uma funcao chamada Main, então ela precisa cobrir as outras funcções
	static void Main()
	{
		// Para mostrar caracteres especiais como acentuação, é necessário definir a codificação de saída
		Console.OutputEncoding = System.Text.Encoding.UTF8;

		// TRABALHANDO COM STRINGS -----------------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM STRINGS -----------------------------------------------------------------");

		// char armazena um unico caracter... sempre usando aspas simples
		// char letra = 'a';
		string texto = "Que sono da porra";
		char primeiraLetraDoTexto = texto[0];

		Console.WriteLine("Primeira letra do texto: " + primeiraLetraDoTexto);

		string meuNome = "            Pedro           ";
		string nomeTratado = meuNome.Trim();

		bool comecaComALetraP = nomeTratado.StartsWith("P");

		string date = "14/09/1999";

		string formatedDate = date.Replace("/", "-");

		string textoDoTeste = "Testando se o contains funciona"; ;
		bool testeDeContains = textoDoTeste.Contains("Testando");
		bool existe = textoDoTeste.Equals("Teestando se o contains funciona");


		Console.WriteLine("Nome: " + meuNome);
		Console.WriteLine("Nome tratado: " + nomeTratado);
		Console.WriteLine("Nome começa com 'P': " + comecaComALetraP);
		Console.WriteLine("Old Date: " + date + " / " + "Formated Date: " + formatedDate);
		Console.WriteLine("O texto contém 'Testando': " + testeDeContains);
		Console.WriteLine("Testo existe: " + existe);

		string texto1 = "A primeira frase.";
		string texto2 = "Segunda frase";
		string paragrafo = texto1 + " " + texto2;
		string caminho = @"C:\teste"; // @ Desativa caracteres especiais \n, \t, etc.

		Console.WriteLine(paragrafo);
		Console.WriteLine(caminho);

		string paragrafo2 = $"A primeira frase. {7} {true} {texto2}";
		Console.WriteLine("Paragrafo2: " + paragrafo2);

		StringBuilder stringBuilder = new StringBuilder();

		stringBuilder.Append(paragrafo);
		stringBuilder.Append(paragrafo2);
		string resultado = stringBuilder.ToString();

		Console.WriteLine("StringBuilder: " + resultado);


		string newTexto = "O {0} gosta de jogos {1} eletronicos";
		string resultadoNewTexto = string.Format(newTexto, "Semison", 10);

		Console.WriteLine(newTexto);
		Console.WriteLine("newTexto formatado: " + resultadoNewTexto);



		// TRABALHANDO COM DATAS -----------------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM DATAS -------------------------------------------------------------------");

		DateOnly dia = new DateOnly(1999, 09, 14); // Devolve somente data
		string diaEmShortDate = dia.ToShortDateString();
		string diaEmLongDate = dia.ToLongDateString();
		string diaEmIngles = dia.ToString(new CultureInfo("en-us"));
		string diaEmInglesEFormatado = dia.ToString("D", new CultureInfo("en-us")); // default avaible configs
		string diaEmPortuguesECustomFormat = dia.ToString("d MMMM yyyy", new CultureInfo("pt-BR"));

		Console.WriteLine("DateOnly: " + dia);
		Console.WriteLine("ShortDateString: " + diaEmShortDate); // 14/09/1999
		Console.WriteLine("LongDateString: " + diaEmLongDate); // terça-feira, 14 de setembro de 1999
		Console.WriteLine("DiaEmIngles: " + diaEmIngles); // 9/14/1999
		Console.WriteLine("DiaEmInglesEFormatado: " + diaEmInglesEFormatado); // Tuesday, September 14, 1999
		Console.WriteLine("diaEmPortuguesECustomFormat: " + diaEmPortuguesECustomFormat); // 14 setembro 1999

		DateTime diaAndHora = new DateTime(1999, 09, 14); // Devolve data e hora
		DateTime diaAndHoraManual = new DateTime(1999, 09, 14, 23, 59, 59);
		DateTime diaAndHoraAtual = DateTime.Now; // Devolve data e hora atual do COMPUTADOR, não o oficial da regiao
		DateTime diaAndHoraAtualRegiao = DateTime.UtcNow; // Devolve data e hora atual base que se usa para calcular a data e hora de outras regioes no mundo.
		DateTime umDiaPraFrente = DateTime.UtcNow.AddDays(1);
		DateTime umDiaPraTras = DateTime.UtcNow.AddDays(-1);

		Console.WriteLine("Dia e hora: " + diaAndHora); // hora default é 00:00:00
		Console.WriteLine("Dia e hora setado manualmente: " + diaAndHoraManual); // 14/09/1999 23:59:59
		Console.WriteLine("Dia e hora atual: " + diaAndHoraAtual); // 18/06/2025 11:50:32
		Console.WriteLine("Dia e hora atual da região: " + diaAndHoraAtualRegiao); // 18/06/2025 14:54:35
		Console.WriteLine("Data UTC um dia pra frente: " + umDiaPraFrente); // 19/06/2025 14:54:35
		Console.WriteLine("Data UTC um dia pra trás: " + umDiaPraTras); // 17/06/2025 14:54:35



		// TRABALHANDO COM ENUMS -------------------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM ENUMS ---------------------------------------------------------------------");

		// Enum não pode ser criado dentro de uma função
		NivelDeDificuldade nivel = NivelDeDificuldade.Alto;
		int nivelEmInteiro = (int)nivel;

		Console.WriteLine("Nível de dificuldade escolhido: " + nivel);
		Console.WriteLine("Nível de dificuldade em inteiro: " + nivelEmInteiro);



		// TRABALHANDO COM VALORES NULOS -----------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM VALORES NULOS -------------------------------------------------------------");

		int? idade = 26;
		bool hasIdade = idade.HasValue;

		Console.WriteLine("idade: " + idade);
		Console.WriteLine("Digitou idade ? " + hasIdade);
		if (hasIdade)
		{
			int valorDeIdade = idade.Value;
			Console.WriteLine("Valor de idade: " + valorDeIdade);
		}



		// TRABALHANDO COM ARRAYS ------------------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM ARRAYS -------------------------------------------------------------------");

		int[] arrayDefinindoTamanho = new int[10]; // Aqui arrays sao coleções com tamanhos fixos. Essa tem tamanho 10;
		int[] arrayDefinindoValores = [1, 6, 12]; // Definindo valores na inicialização. Ele entende que o array tem tamanho fixo de 3, por ter 3 elementos.

		arrayDefinindoTamanho[0] = 123;

		Console.WriteLine("Tamanho total do array: " + arrayDefinindoTamanho.Length);
		Console.WriteLine("Posição 0 do array: " + arrayDefinindoTamanho[0]);
		Console.WriteLine($"ArrayComValoresDefinidos: {arrayDefinindoValores[0]}, {arrayDefinindoValores[1]}, {arrayDefinindoValores[2]}");

		// arrays de multiplas dimensoes
		int[,] arrayDuasDimensoes = new int[2, 2]; // virgula marca quantas dimensoes (1 cada lado da virgula), new int com 2 linhas e 2 colunas

		arrayDuasDimensoes[0, 0] = 1;
		arrayDuasDimensoes[0, 1] = 2;

		Console.WriteLine($"Linha 0 | Coluna 0 = {arrayDuasDimensoes[0, 0]}");
		Console.WriteLine($"Linha 1 | Coluna 1 = {arrayDuasDimensoes[1, 1]}");
		Console.WriteLine($"Linha 0 | Coluna 1 = {arrayDuasDimensoes[0, 1]}");



		// TRABALHANDO COM LISTAS ------------------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM LISTAS -------------------------------------------------------------------");

		List<int> listaDeInteiros = new List<int>();

		listaDeInteiros.Add(403);
		listaDeInteiros.Add(404);

		Console.WriteLine($"Tamanho da lista de inteiros: {listaDeInteiros.Count}"); // Mostra o tamanho da lista
		Console.WriteLine($"Posição 1 da lista: {listaDeInteiros[0]}");
		Console.WriteLine($"Posição 2 da lista:  {listaDeInteiros[1]}");

		listaDeInteiros.Remove(403);

		Console.WriteLine($"Tamanho da lista de inteiros (pós remove): {listaDeInteiros.Count}"); // Remove altera o tamanho da lista
		Console.WriteLine($"Posição 1 da lista (pós remove): {listaDeInteiros[0]}"); // Remove faz com que o indeice dos elementos se atualize conforme o que foi removido

		int primeiroElementoDaListaDeInteiros = listaDeInteiros.First();

		Console.WriteLine($"Primeiro elemento usando First: {primeiroElementoDaListaDeInteiros}");

		listaDeInteiros.Add(403);
		int ultimoElementoDaListaDeInteiros = listaDeInteiros.Last();

		Console.WriteLine($"Ultimo elemento usando Last: {ultimoElementoDaListaDeInteiros}");

		int selecionandoElementoPelaPosicao = listaDeInteiros.ElementAt(1);

		Console.WriteLine($"Elemento selecionado usando posição: {selecionandoElementoPelaPosicao}");

		listaDeInteiros.RemoveAt(0); // Remove um indice especifico

		Console.WriteLine($"Tamanho da lista de inteiros (pós removeAt): {listaDeInteiros.Count}");
		Console.WriteLine($"Posição 1 da lista (pós removeAt): {listaDeInteiros[0]}");

		listaDeInteiros.Clear(); // Limpa a lista inteira aplicando remove em todos os elementos.

		Console.WriteLine($"Tamanho da lista de inteiros (pós Clean): {listaDeInteiros.Count}");


		List<string> listaDeStrings = new List<string>();

		listaDeStrings.Add("Hello");
		listaDeStrings.Add("World");

		string juntandoPalavrasDaListaString = string.Join(" ", listaDeStrings);

		Console.WriteLine($"Strings da Lista concatenadas por join: {juntandoPalavrasDaListaString}");

		List<decimal> listaDeDecimais = new List<decimal>();

		listaDeDecimais.Add(2.5m);

		List<bool> listaDeBooleanos = new List<bool>();

		listaDeBooleanos.Add(true);

		List<object> listaDeValoresDiferentes = new List<object>();

		listaDeValoresDiferentes.Add("texto");
		listaDeValoresDiferentes.Add(2);
		listaDeValoresDiferentes.Add(true);
		listaDeValoresDiferentes.Add(7.5f);



		// TRABALHANDO COM DICIONARIOS -------------------------------------------------------------------------------
		Dictionary<int, string> meuPrimeiroDicionario = new Dictionary<int, string>(); // Chave int e valor string.. Precisamos tipar a chave e valor

		meuPrimeiroDicionario.Add(0, "primeiro item");
		meuPrimeiroDicionario.Add(1, "segundo item");
		meuPrimeiroDicionario.Add(2, "terceiro item");

		string valorDoItemDicionario = meuPrimeiroDicionario[0]; //Passa nao o index mas sim a chave

		Console.WriteLine($"Valor do meu Dicionario: {valorDoItemDicionario}");

		bool existeNoDicionario = meuPrimeiroDicionario.ContainsKey(5); // Verifica se existe a key no dicionario

		Console.WriteLine($"Existe a key no dicionario: {existeNoDicionario}");



		// TRABALHANDO COM HASH-SET ----------------------------------------------------------------------------------
		//Parece uma lista mas todos os valores dentro do hash-set devem ser unicos
		HashSet<int> meuHashSet = new HashSet<int>();

		meuHashSet.Add(1);
		meuHashSet.Add(2);
		meuHashSet.Add(1); // Esse ele nao adiciona e também nao dispara erro. Ela só garante que nao teram itens repetidos

		Console.WriteLine($"Numero de itens no HashSet: {meuHashSet.Count}");



		// TRABALHANDO COM CLASSES -----------------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM CLASSES -------------------------------------------------------------------");

		Carro meuCarro = new Carro("Corsa"); //Forma 1

		meuCarro.Ligar();

		meuCarro.Desligar();

		meuCarro.Modelo = "Fiat"; //Usando o set da propriedade Modelo que é publica
		meuCarro.Cor = Cor.Vermelho; //Usando enum de Cor
		meuCarro.LancadoEm = new DateOnly(2021, 01, 01);
		meuCarro.NomeDoModelo();

		Carro meuCarro2 = new Carro("Honda") //Forma 2 -> Posso passar tanto como parametro usando o construtor quanto usando required e passando no objeto
		{
			Modelo = "Honda",
			LancadoEm = new DateOnly(2020, 02, 05),
			Cor = Cor.Azul
		};

		meuCarro2.NomeDoModelo();



		// TRABALHANDO COM FUNÇÕES -----------------------------------------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("> TRABALHANDO COM FUNÇÕES -------------------------------------------------------------------");
		var operacoesMatematicas = new OperacoesMatematicas();
		int resultadoOperacaoAdicionar = operacoesMatematicas.Adicionar(valor1: 1, valor2: 7);

		Console.WriteLine($"Resultado da função adicionar: {resultadoOperacaoAdicionar}");

		var resultadoRetornandoDoisValores = operacoesMatematicas.RetornandoDoisValores(valor1: 5, valor2: 5);

		Console.WriteLine($"Resultado da função {resultadoRetornandoDoisValores.nomeDaFuncao}: {resultadoRetornandoDoisValores.resultadoDaAdicao}");

		(int resultadoRetornandoDoisValoresDeOutraForma, string nomeDaFuncao) = operacoesMatematicas.RetornandoDoisValores(valor1: 10, valor2: 10);

		Console.WriteLine($"Resultado de outra forma da função '{nomeDaFuncao}': {resultadoRetornandoDoisValoresDeOutraForma}");

		operacoesMatematicas.Teste(valor1: 1);

		var resultadoNovo = OperacoesMatematicas.Subtrair(2, 1); //Quando é static nao precisa mais instanciar o operacoesMatematicas em uma variavel pra entao acessar a funcao

		Console.WriteLine(resultadoNovo);


		// TRABALHANDO COM CONDICIONAIS -------------------------------------------------------------------------------

		//if - else - else if padrão


		//Exemplo de ternario
		int numeroTernario = 7;
		string autor = numeroTernario == 7 ? "Pedro Marques" : "Semison Douglas";
		Console.WriteLine($"Ternario de autor: {autor}");

		string teste;
		teste = numeroTernario != 2 ? "Teste 1" : "Teste 2";
		Console.WriteLine($"Ternario de Teste: {teste}");


		//Switch Case
		Cor corSwitchCase = Cor.Azul;

		switch (corSwitchCase)
		{
			case Cor.Amarelo:
				{
					Console.WriteLine($"Cor do Switch: {Cor.Amarelo}");
				}
				break;
			case Cor.Vermelho:
				{
					Console.WriteLine($"Cor do Switch: {Cor.Vermelho}");
				}
				break;
			case Cor.Azul:
				{
					Console.WriteLine($"Cor do Switch: {Cor.Azul}");
				}
				break;
			default:
				{
					Console.WriteLine("Nenhuma cor encontrada");
				}
				break;
		}

		//Switch ternário
		// Se o numero for 7 salva Pedro, se for 1 salva Semison, se for 3 salva Jubicleison, _ é pra qualquer outro case
		string resultadoSwitchTernario = numeroTernario switch
		{
			7 => "Pedro",
			1 => "Semison",
			3 => "Jubicleison",
			_ => "Nome desconhecido"
		};

		Console.WriteLine($"Switch case Ternario: {resultadoSwitchTernario}");
	}
}
