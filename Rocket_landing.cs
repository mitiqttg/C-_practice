using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rocket = @"
                    ^
                   /^\
                  /___\
                 |=====|
                 |     |
                 | [ ] |
                 | [ ] |
                 | [ ] |
                 | [ ] |
                 |     |
                 |     |
                /|^^M^^|\
               / |##I##| \
              |  |##T##|  |
              |  |##I##|  |
              |  |#####|  |
              |  |#####|  |
              |  |#####|  |
              |  |#####|  |
             /_###########_\
            /###############\
                   ###
                 ##   ##
                ##     ##
            ";

          for (int counter = 10; counter >= 0; counter--)
          {
              Console.Clear();
              Console.WriteLine("Landing in: " + counter);
              Console.WriteLine(rocket);
              rocket = "\r\n" + rocket;
              Thread.Sleep(1000);
          }
          
          Console.WriteLine("Landed successfully!");
          
          Console.ReadKey(); 
        }
    }
}
