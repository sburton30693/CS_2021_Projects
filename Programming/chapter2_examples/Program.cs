/*
 * Spencer Burton
 * Chapter 2 Examples
 * Gamedev 1st
 * Last Edited: 9/21/2021
 */


//Imports section
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chapter2_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data_names = {"First Name", "Middle Name", "Last Name", "Age", "Date of Birth", "Address", "Favorite Movie", "Favorite Ice Cream", 
                "Favorite Element", "Social Security Number", "Favorite Appendage", "Eye Color", "Height", "Weight", "Mother's Name", "Father's Name", 
                "Mother's Maiden Name", "Password", "Credit Card Number", "Vacation Location"};
            string[] data_values = new string[data_names.Length];

            //Loop through data names and collect data into the data array
            for(int i = 0; i < data_names.Length; i++)
            {
                Console.Write(String.Format("Enter your {0}: ", data_names[i]));

                String input = Console.ReadLine();
                while(input == null)
                {
                    input = Console.ReadLine();
                }
                data_values[i] = input;
            }

            //Print out the data
            Console.WriteLine("\nHere is your information:");
            for(int i = 0; i < data_names.Length; i++)
            {
                Console.WriteLine(String.Format("{0,25}: {1}", data_names[i], data_values[i]));
            }
            
            //Pause before exiting
            Console.WriteLine("\nThank you for your information!");
            Console.Read();
        }
    }
}
