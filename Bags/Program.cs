using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const double BAG_PRICE = 5.50;
            const double largeBox = 3.00;
            const double mediumbox = 2.50;
            const double smallBox = 2.00;
            const int largecapacity = 20;
            const int mediumcapacity = 10;
            const int smallcapacity = 5;

            // Get input from user
            Console.WriteLine("Enter the number of 2-lb bags of coffee to order:");
            int numBags = int.Parse(Console.ReadLine());

            // Calculate the number of boxes needed
            int numLargeBoxes = numBags / largecapacity;
            int numMediumBoxes = (numBags % largecapacity) / mediumcapacity;
            int numSmallBoxes = ((numBags % largecapacity) % mediumcapacity) / smallcapacity;

            // Calculate the cost of the boxes
            double largeBoxCost = numLargeBoxes * largeBox;
            double mediumBoxCost = numMediumBoxes * mediumbox;
            double smallBoxCost = numSmallBoxes * smallBox;

            // Calculate the total cost of the order
            double totalCost = (numBags * BAG_PRICE) + largeBoxCost + mediumBoxCost + smallBoxCost;

            // Display the result
            Console.WriteLine($"The total cost of your order is ${totalCost:0.00}");
        }
    }
}
