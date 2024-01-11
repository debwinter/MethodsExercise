namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }

            return total;
        }

        //public static int Add(int x, int y)
        //{
        //    int answer = x + y;
        //    return answer;
        //}

        //public static int Subtract(int x, int y)
        //{
        //    int answer = x - y;
        //    return answer;
        //}

        //public static int Multiply(int x, int y)
        //{
        //    int answer = x * y;
        //    return answer;
        //}

        //public static double Divide(double x, double y)
        //{
        //    double answer = x / y;
        //    return answer;
        //}

        static void Main(string[] args)
        {
            int add2 = Sum(3, 6);
            Console.WriteLine(add2);

            int add3 = Sum(8, 2, 7);
            Console.WriteLine(add3);

            int add7 = Sum(2, 6, 3, 8, 6, 4, 2);
            Console.WriteLine(add7);

            //int sum = Add(input1, input2);
            //Console.WriteLine($"{input1} + {input2} = {sum}");

            //int minus = Subtract(input1, input2);
            //Console.WriteLine($"{input1} - {input2} = {minus}");

            //int product = Multiply(input1, input2);
            //Console.WriteLine($"{input1} x {input2} = {product}");

            ////double num1 = Convert.ToInt64(input1);
            ////double num2 = Convert.ToInt64(input2);

            //double fraction = Divide(input1, input2);
            //Console.WriteLine($"{input1} ÷ {input2} = {fraction}");
        }
    }
}
