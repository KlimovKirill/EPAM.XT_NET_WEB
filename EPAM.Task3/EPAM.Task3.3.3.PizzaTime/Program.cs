using EPAM.Task3._3._3.PizzaTime.Pizzeria;
using EPAM.Task3._3._3.PizzaTime.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3._3._3.PizzaTime
{
    internal class Program
    {
        public delegate void OrderHandler(Pizza order);
        static void Main(string[] args)
        {
            TestPizzeria testPizzeria = new TestPizzeria("DoDo Pizza");

            TestUser testUser = new TestUser("Robby", Guid.NewGuid());
            PizzeriaSimulation(testUser, testPizzeria, Pizza.Hawaii);
        }

        static void PizzeriaSimulation(TestUser user, TestPizzeria pizzeria, Pizza order)
        {
            user.onMakeOrder += pizzeria.OrderToCook;
            user.onMakeOrder += pizzeria.DisplayOnScoreboard;
            pizzeria.onProcessingOrder += user.GetOrder;
            user.MakeOrder(order);
            pizzeria.onProcessingOrder -= user.GetOrder;
        }
    }
}
