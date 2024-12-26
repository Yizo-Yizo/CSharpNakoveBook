using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Fraction
    {
        // Ch 14 No. 25
        // Properties
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        // Constructor
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            Numerator = numerator;
            Denominator = denominator;
            Simplify(); // Automatically simplify the fraction upon creation
        }

        // Method to simplify the fraction
        public void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            // Ensure that the denominator is always positive
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        // Method to calculate the Greatest Common Divisor (GCD)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Property to get the decimal value of the fraction
        public decimal DecimalValue
        {
            get
            {
                return (decimal)Numerator / Denominator;
            }
        }

        // Static method to parse a string into a Fraction object
        public static Fraction Parse(string fraction)
        {
            // Split the string by '/'
            string[] parts = fraction.Split('/');

            // Convert parts to integers
            int numerator = int.Parse(parts[0].Trim());
            int denominator = int.Parse(parts[1].Trim());

            // Create a new Fraction object
            return new Fraction(numerator, denominator);
        }

        // Override ToString method to represent the fraction as a string
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
