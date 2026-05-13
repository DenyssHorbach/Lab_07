using Lab;
namespace Lab
{
    class Program
    {
        static int Main()
        {
            try
            {
                ExpressionCalculator[] objects = new ExpressionCalculator[2];
                
                objects[0] = new ExpressionCalculator(a: 2.0, c: 10.0, d: 46.0);
                
                objects[1] = new ExpressionCalculator(a: 4.0, c: 5.0, d: 10.0);

                for (int i = 0; i < objects.Length; i++)
                {
                    Console.WriteLine($"--- calculating for obj {i + 1} ---");
                    try
                    {
                        double result = objects[i].CalculateFullExpression();
                        Console.WriteLine($"result: {result:F4}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"math error: {ex.Message}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"error /: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }

            Console.WriteLine("\n press any key to exit");
            Console.ReadKey();

            return 0;
        }
    }
}