using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3._1._1.WeakestLink
{
    public class Program
    {
        public static void SearchOfLast(Queue<int> roundOfPeople, int n)
        {
            bool flag = true;
            int countOfRounds = 1;
            while (roundOfPeople.Count != 1)
            {

                if (flag)
                {
                    roundOfPeople.Enqueue(roundOfPeople.Dequeue());
                    flag = !flag;
                }
                else
                {
                    roundOfPeople.Dequeue();
                    flag = !flag;
                    
                    Console.WriteLine($"Раунд {countOfRounds}. Вычеркнут человек. Людей осталось: {n - countOfRounds}");
                    countOfRounds++;
                }

            }

        }

        public static void Main(string[] args)
        {
            try
            {
                Queue<int> roundOfPeople = new Queue<int>();

                Console.WriteLine("Введите N: ");
                int.TryParse(Console.ReadLine(), out int n);

                for (int i = 1; i <= n; i++)
                {
                    roundOfPeople.Enqueue(i);
                }

                Console.WriteLine("Сгенерирован круг людей. Начинаем вычеркивать каждого второго.");

                SearchOfLast(roundOfPeople, n);
                
                Console.WriteLine($"Игра окончена. Невозможно вычеркнуть больше людей. Последний оставшийся человек под номером: {roundOfPeople.Peek()}");
            }
            catch
            {
                Console.WriteLine("Ошибка! Неверные входные данные.");
            }
        }
    }
}
