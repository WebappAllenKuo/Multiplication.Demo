namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// 使用二層迴圈完成九九乘法表, 通常書籍或初學者會這麼寫
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int firstNumber = 2; firstNumber <= 9; firstNumber ++)
            {
                for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
                {
                    string result = $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber, 2}";
                    Console.WriteLine(result);
                }

                Console.WriteLine();
            }
        }
    }
}