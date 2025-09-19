using System;

namespace HelloWorld
{
	public class Carro
	{
		public string Modelo { get; set; } //required na frente de public diz que é obrigatório passar um valor inicial
		public DateOnly LancadoEm { get; set; }
		public Cor Cor { get; set; }

		//Podemos também criar um metodo construtor para a classe. Assim toda vez instanciar a classe (new Carro) ele chama essa função.
		public Carro(string modelo) //passando como parametro da classe construtora ele passa a ser obrigatorio para instanciar
		{

		}

		public void NomeDoModelo()
		{
			Console.WriteLine(Modelo);
		}


		public void Ligar()
		{
			Console.WriteLine("Carro LIGADO");
		}

		public void Desligar()
		{
			Console.WriteLine("Carro DESLIGADO");
		}
	}
}

