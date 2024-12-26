using System.Text;

namespace CreatingAndUsingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ch 11 No. 8
            for (int i = 1; i <= 10; i++)
            {
                Cat cat = new Cat
                {
                    Name = "Cat" + i
                };
                cat.SayMiau();
            }
        }


    }
}
