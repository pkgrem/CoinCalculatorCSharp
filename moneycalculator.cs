using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("How much Money would you like to convert?");
      string MoneyConvert = Console.ReadLine();
      double Money = Convert.ToDouble(MoneyConvert);
      //Console.WriteLine(Money);
      Console.WriteLine($"We are going to convert your money into coins. You currently have {Money} coins, this is equal to:...");
      int gold = 10;
      int silver = 5;
      int bronze = 1;

      double goldCoins = Math.Floor(Money/gold);
      double Remainingcoins1 = Money % gold; 
      double silverCoins = Math.Floor(Remainingcoins1/silver); 
      double Remainingcoins2 = Remainingcoins1 % silver;
      double bronzeCoins = Math.Floor(Remainingcoins2/bronze); 



      Console.WriteLine(goldCoins + " Gold Coins");
      Console.WriteLine(silverCoins + " Silver Coins");
      Console.WriteLine(bronzeCoins + " Bronze Coins");
     // Console.WriteLine(Remainingcoins2); could use this as it is the remainder.

    }
  }
}
