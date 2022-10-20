namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number thats greater than 9");

            var answer = int.Parse(Console.ReadLine());

            string response;

            if (answer < 9)
            {
                Console.WriteLine($"{answer} is not greater than 9.");
            }
            else
            {
                Console.WriteLine($"Yess!!! {answer} is greater than or equal to nine!!!");
            }

            //var answer = 4;

            //var response = (answer < 9) ? " is less than nine" : " is greater than or equal to nine"; 
            

        
        }
       
    }
}
