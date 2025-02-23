namespace Rock_Paper_Scisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("За да започнеш трябва да въведеш камък, ножица, хартия");

            string type = Console.ReadLine().ToLower();

            Random random = new Random();
            int n = random.Next(1, 4);
            string simvol = "";

            int PC = 0;
            int AI = 0;

            switch (n)
            {
                case 1:
                    simvol = "камък";
                    break;
                case 2:
                    simvol = "ножица";
                    break;
                case 3:
                    simvol = "хартия";
                    break;
            }

            if (type != "камък" && type != "ножица" && type != "хартия")
            {
                Console.WriteLine("Въведи валиден символ (Камък,Ножица,Хартия)");
            }

            else if (type == "камък" && simvol == "хартия" || type == "ножица" && simvol == "камък" || type == "хартия" && simvol == "ножица")
            {
                Console.WriteLine(simvol);
                Console.WriteLine("Ти загуби");
                AI++;
            }

            else if (type == "камък" && simvol == "ножица" || type == "ножица" && simvol == "хартия" || type == "хартия" && simvol == "камък")
            {
                Console.WriteLine(simvol);
                Console.WriteLine("Ти спечели");
                PC++;
            }

            else if (type == "камък" && simvol == "камък" || type == "ножица" && simvol == "ножица" || type == "хартия" && simvol == "хартия")
            {
                Console.WriteLine(simvol);
                Console.WriteLine("Равенство");
            }
            else
            {
                Console.WriteLine("Опа лянка не съм оправил кода");
                Console.WriteLine("Ако нещо такова стане оправи кода в GITHUB");
            }
            Console.WriteLine($"Ти: {PC}, AI: {AI}");
        }
    }
}
