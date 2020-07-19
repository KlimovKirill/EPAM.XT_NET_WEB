using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EPAM.Task3._3._3.PizzaTime.Program;

namespace EPAM.Task3._3._3.PizzaTime.Pizzeria
{
    internal class TestPizzeria
    {
        public event OrderHandler onProcessingOrder;

        public string Name { get; set; }

        public TestPizzeria(string name)
        {
            Name = name;
        }

        public void OrderToCook(Pizza order)
        {
            Console.WriteLine($"Pizzeria Name: {Name} | Cooking... {order}" + Environment.NewLine);
        }

        public void DisplayOnScoreboard(Pizza order)
        {
            Console.WriteLine($"Your pizza {order} is ready! Get it! " + Environment.NewLine);
            onProcessingOrder?.Invoke(order);
        }
    }
}
