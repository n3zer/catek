// 1. *Расчёт скорости при свободном падении:*  
//    Рассчитайте скорость тела при свободном падении через 
//    время t по формуле: v = v_0 + g * t, где v_0 —
//     начальная скорость, g = 9.8 метров в секунду в квадрате, 
//     t — время падения. Выведите как скорость, так и путь,
//      пройденный телом по формуле: s = v_0 * t + (1 / 2) * g * t^2.

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double V_0, V;
            double g = 9.8;
            double t;

            double s;

            Console.Write("v_0");
            Double.TryParse(Console.ReadLine(), out V_0);
            Console.Write("t");
            Double.TryParse(Console.ReadLine(), out t);
            V = V_0+g*t;

            s = V_0 * t + (1/2)*g*(t*t);

            Console.WriteLine(s);


        }
    }
}
