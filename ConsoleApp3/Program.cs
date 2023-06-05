namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Püramiid();
            MaxLINQ();
            SingleOrDefault();
            IfjaElseFailimeetod();
        }

        static void Püramiid()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("1");
                }
                Console.Write("\n");
            }
        }

        public static void MaxLINQ()
        {
            Console.WriteLine("Max LINQ");

            //var max = PeopleList.peoples.Max();

            //Console.WriteLine("People Id: {0}, Student name: {1}",
            //max.Id, max);
        }

        public static void SingleOrDefault()
        {
            IList<int> oneElement = new List<int>() { 7 };

            Console.WriteLine("Single or Default");

            //singleOrDefault lubab ainult ühte elementi kasutada listis
            var singleOrDefault = oneElement.SingleOrDefault();

            Console.WriteLine(singleOrDefault);
        }

        public static void IfjaElseFailimeetod()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
                "veateate. Kui on õige, siis ütleb, " +
                "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/opilane/source/repos/FileToDesktop.txt";
            string wrightPath = "C:/Users/opilane/source/repos/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
        }
    }
}