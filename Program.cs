using System;
using System.IO;

namespace КЛАССЫ._ОБЪЕКТНОЕ_МОДЕЛИРОВАНИЕ
{
    
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"Kub_output.txt");
            var new_in = new StreamReader(@"Kub_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif

            Kub k = new Kub();
            k.Load();
            k.Info();

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
#else

            Console.ReadKey();
#endif
        }
    }

}
