// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;


namespace SeriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SeriesApp();
        }

        
        static void SeriesApp()
        {
            Console.WriteLine("choose number : 1.choose 2.show 3.add episod 4.show all series");
           

            switch (int.Parse(Console.ReadLine()))
            {
                case 2:

                    Console.WriteLine("what is the name of the serie");
                    string showEpisod = Console.ReadLine();


                    FileStream showS = new FileStream(@"C:\series\series.txt", FileMode.Open);
                    using (StreamReader reader = new StreamReader(showS))
                    {
                        Console.WriteLine(reader.ReadLine);
                    }

                    break;

                case 3:

                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("add the name of the episod");
                        string addEpisod = Console.ReadLine();

                        FileStream addS = new FileStream(@"C:\series\series.txt", FileMode.Append);
                        using (StreamWriter writer = new StreamWriter(addS))
                        {
                            writer.WriteLine(addEpisod);
                        }
                    }


                    SeriesApp();
                    break;


                case 4:

                    FileStream showAS = new FileStream(@"C:\series\series.txt", FileMode.Open);
                    using (StreamReader reader = new StreamReader(showAS))
                    {
                        Console.WriteLine(reader.ReadToEnd);
                    }


                    break;
                    

            }
        }

        













    }
}