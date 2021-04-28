using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    Interador listinha = new Interador();

    bool showMenu = true;
      while (showMenu)
      {
        showMenu = MainMenu(listinha);
      }
  }
  private static bool MainMenu(Interador listinha)
  {          
    Console.WriteLine("\r\nEscolha sua opção:");
    Console.WriteLine("1) Retângulo");
    Console.WriteLine("2) Triângulo retângulo");
    Console.WriteLine("3) Círculo");
    Console.WriteLine("4) Mostrar anteriores");
    Console.WriteLine("5) Mostrar anteriores e sair");
    Console.Write("\r\nDigite sua opção: ");
 
    switch (Console.ReadLine())
    {
      case "1":
      Console.Clear();
      Console.Write("\r\nEntre a base e depois entre com altura do retângulo.\n");
      Retangulo ret = new Retangulo(largura: Convert.ToDouble(Console.ReadLine()), altura: Convert.ToDouble(Console.ReadLine()));
      listinha.Figuras.Add(ret);

      // acessando métodos get
      Console.WriteLine("\r\nBase:\t\t{0:0.0}", ret.Largura);
      Console.WriteLine("Altura:\t\t{0:0.0}", ret.Altura);
      ret.ImprimirFig();

      return true;
      
      case "2":
      Console.Clear();
      Console.Write("\r\nEntre a base e depois entre com altura do triângulo retângulo.\n");
      Triangulo tri = new Triangulo(baset: Convert.ToDouble(Console.ReadLine()), altura: Convert.ToDouble(Console.ReadLine()));
      listinha.Figuras.Add(tri);

      // acessando métodos get
      Console.WriteLine("\r\nBase:\t\t{0:0.0}", tri.Baset);
      Console.WriteLine("Altura:\t\t{0:0.0}", tri.Altura);
      tri.ImprimirFig();

      return true;
      
      case "3":
      Console.Clear();
      Console.Write("\r\nEntre com o raio do círculo.\n");
      Circulo cir = new Circulo(raio: Convert.ToDouble(Console.ReadLine()));
      listinha.Figuras.Add(cir);

      // acessando métodos get
      Console.WriteLine("\r\nRaio:\t\t{0:0.0}", cir.Raio);
      cir.ImprimirFig();

      return true;

      case "4":
      Console.Clear();
      Console.WriteLine("Figuras:");
      Console.Write("===============================");
      listinha.ImprimirFiguras();
      return true;

      case "5":
      Console.Clear();
      if (listinha.Figuras.Count == 0)
      {
          Console.WriteLine("Ainda não há itens");

      }
      else
      {
        listinha.ImprimirFiguras();
   
      }
      return false;
      default:
      return true;
    }
  }


}