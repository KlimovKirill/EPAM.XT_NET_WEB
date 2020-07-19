using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EPAM.Task3._3._3.PizzaTime.Program;

namespace EPAM.Task3._3._3.PizzaTime.User
{
    internal class TestUser
    {
        public event OrderHandler onMakeOrder;
        public string Name { get; }
        public Guid ID { get; }

        public TestUser(string userName, Guid userId)
        {
            this.Name = userName;
            this.ID = userId;
        }

        public void MakeOrder(Pizza order)
        {
            Console.WriteLine($"ID: {ID} Name: {Name} | Making Order {order}" + Environment.NewLine); ;
            onMakeOrder?.Invoke(order);
        }

        public void GetOrder(Pizza pizza)
        {
            Console.WriteLine($"ID: {ID} Name: {Name} | Getting Order {pizza}" + Environment.NewLine);
        }


    }
}
