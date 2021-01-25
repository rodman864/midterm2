using System;
using System.Collections;
using System.Collections.Generic;

namespace Diner
{
    public class MckinneyDiner
    {
        private Queue<int> waitingQueue = new Queue<int>();

        public void addCustomerToQueue(int parameter)
        {
            waitingQueue.Enqueue(parameter);
        }

        public void showCustomer()
        {
            Console.Write("This is the amount of customers that need to be seated: " +
                                 waitingQueue.Count);
                   
        }
        public void actualCustomer()
        {
            foreach (var item in waitingQueue)
            {
                Console.WriteLine("Customer: " + item);
            }
        }
        public void CustomerSeated()
        {
            waitingQueue.Dequeue();
        }
        public class Dish
        {
            private Stack<string> CustomerStack = new Stack<string>();
            private Stack<string> undoCustomerStack = new Stack<string>();


            public void CustomerDishes(string myFirstPage)
            {
                CustomerStack.Push(myFirstPage);

                foreach (var item in CustomerStack)
                {
                    Console.WriteLine("The first customers are using: " + item);
                }
            }
            public void UndoDishes()
            {
                string lastCustomer = CustomerStack.Pop();
                undoCustomerStack.Push(lastCustomer);
            }
            public void RedoDishes()
            {
                foreach (var item in undoCustomerStack)
                {
                    Console.WriteLine("The dishes are put back."
                                  + item);
                }

            }
        }


        static void Main(string[] args)
        {
            MckinneyDiner restaurantCustomer = new MckinneyDiner();
            restaurantCustomer.addCustomerToQueue(1);
            restaurantCustomer.addCustomerToQueue(2);
            restaurantCustomer.addCustomerToQueue(3);
            restaurantCustomer.addCustomerToQueue(4);
            restaurantCustomer.addCustomerToQueue(5);
            restaurantCustomer.addCustomerToQueue(6);

            restaurantCustomer.CustomerSeated();

            restaurantCustomer.actualCustomer();

            MckinneyDiner Cutomerpaid = new MckinneyDiner();
            Console.WriteLine("Customer 1 has paid for their meal!");
            Console.WriteLine("The server can place the dishes back and seat the next customer!");

            Dish CustomerDishes = new Dish();
            CustomerDishes.CustomerDishes("The first customer has used three sets of dishes");
            CustomerDishes.CustomerDishes("The second customer has used four sets of dishes");
            CustomerDishes.CustomerDishes("The fourth customer has used five set of dihes");

            CustomerDishes.UndoDishes();
            CustomerDishes.RedoDishes();


        }

    }
}
