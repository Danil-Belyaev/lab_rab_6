using System;

namespace КЛАССЫ._ОБЪЕКТНОЕ_МОДЕЛИРОВАНИЕ
{
    class Kub
    {
        private double a;

        public double V()
        {
            return a * a * a;
        }
        public double S()
        {
            return 6 * a * a;
        }

        public void Info()
        {
            String str =
                "   *******\n" +
                " * |    **\n" +
                "******** *\n" +
                "*  |___*_*\n" +
                "* /куб **\n" +
                "********\n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("Сторона куба = {0:0.00}", a));
            Console.WriteLine(string.Format("Объем куба = {0:0.00}", V()));
            Console.WriteLine(string.Format("Площадь куба = {0:0.00}", S()));
        }
        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
        }
    }
}