using System;

namespace MethodOverloarding {

    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to add two strings (concatenation)
        public string Add(string a, string b)
        {
            return a + b;
        }
    }
}

