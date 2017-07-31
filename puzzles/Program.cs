using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin();
            TossMultipleCoins(10);
        }
        static int[] RandomArray(){
            int[] myArray = new int[10];
            System.Console.WriteLine(myArray);
            Random r = new Random();
            for(int i =0; i < myArray.Length; i++){
                myArray[i] = r.Next(5, 26);
            }
        }
        static string TossCoin(){
            System.Console.WriteLine("Tossing a coin ...");
            Random RandObj = new Random();
            int CoinToss = RandObj.Next(0,2);
            string res = "";
            if (CoinToss == 0){
                System.Console.WriteLine("Heads");
                res = "Heads";
            } else {
                System.Console.WriteLine("Tails");
                res = "Tails";
            }
            return res;
        }
        static Double TossMultipleCoins(int Num){
            int countHeads = 0;
            for (int i = 0; i < Num; i++){
                if (TossCoin() == "Heads"){
                    countHeads++;
                    }
                }
                return (Double)countHeads/Num;
            }
            static string Names
        }
    }
