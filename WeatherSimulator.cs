namespace WeatherStationSimulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Snowy", "Windy", "Stormy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 30);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            double averageTemp = CalculateAverageTemp(temperature);

            Console.WriteLine("The average temp is: " + averageTemp);
            Console.WriteLine("The max temp is: " + temperature.Max());
            Console.WriteLine("The min temp is: " + temperature.Min());
            Console.WriteLine("The most common condition is: " + MostCommonCondition(conditions));
            Console.ReadKey();
        }

        static double CalculateAverageTemp(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            double average = sum / temperature.Length;
            return average;
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[i] == conditions[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;

        }
    }
}
