using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    // Ch 14 No. 26
    public class FractionTest
    {
        public void TestFractions()
        {
            // Test 1: Simple Fraction
            Fraction fraction1 = new Fraction(1, 2);
            Console.WriteLine("Fraction 1:");
            Console.WriteLine($"String Representation: {fraction1}");
            Console.WriteLine($"Decimal Value: {fraction1.DecimalValue}");
            Console.WriteLine();

            // Test 2: Parsing a Positive Fraction
            Fraction fraction2 = Fraction.Parse("3/4");
            Console.WriteLine("Fraction 2 (Parsed):");
            Console.WriteLine($"String Representation: {fraction2}");
            Console.WriteLine($"Decimal Value: {fraction2.DecimalValue}");
            Console.WriteLine();

            // Test 3: Parsing a Negative Fraction
            Fraction fraction3 = Fraction.Parse("-7/3");
            Console.WriteLine("Fraction 3 (Parsed):");
            Console.WriteLine($"String Representation: {fraction3}");
            Console.WriteLine($"Decimal Value: {fraction3.DecimalValue}");
            Console.WriteLine();

            // Test 4: Parsing a Whole Number
            Fraction fraction4 = Fraction.Parse("5/1");
            Console.WriteLine("Fraction 4 (Parsed):");
            Console.WriteLine($"String Representation: {fraction4}");
            Console.WriteLine($"Decimal Value: {fraction4.DecimalValue}");
            Console.WriteLine();

            // Test 5: Parsing an Invalid Fraction (Denominator as zero)
            try
            {
                Fraction fraction5 = Fraction.Parse("4/0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fraction 5 (Invalid):");
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine();
            }

            // Test 6: Parsing an Improper Fraction
            Fraction fraction6 = Fraction.Parse("10/3");
            Console.WriteLine("Fraction 6 (Parsed):");
            Console.WriteLine($"String Representation: {fraction6}");
            Console.WriteLine($"Decimal Value: {fraction6.DecimalValue}");
            Console.WriteLine();
        }
    }
}
