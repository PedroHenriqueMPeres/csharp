using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses.Classes
{
    public class Carro
    {
  public string Marca;
  public string Modelo;

  public string cor;

  public string potencia;

  public string qntPortas;

  public void Acelerar()
  {
      Console.WriteLine("Vrum! Vrum!");
  }
  public void Ligar()
  {
      Console.WriteLine("!ON!");
  }
  public void Desligar()
  {
      Console.WriteLine("!OFF!");
  }
  public void Freiar()
  {
      Console.WriteLine("!IrRrRrR!");
  }

  public void Morrendo()
  {
      Console.WriteLine("!Cof-Cof!");
  }

    }
}


