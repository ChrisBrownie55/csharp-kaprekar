using System;

namespace kaprekar {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Welcome to Kaprekar's Constant!");
      Kaprekar kaprekar = new Kaprekar();
      Console.WriteLine(kaprekar.SortNumber(true));
    }
  }
}
