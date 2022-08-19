namespace Demo03
{
    internal class Program
    {
        /// <summary>
        /// 將您想要寫的功能, 盡量練習放在一個類別裡, 不要直接在 main裡寫完
        /// 日後若想在 Windows Forms, ASP.NET, WPF 等各類型專案, 就會比較方便直接叫用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplicationTable.GenerateTables());
        }
    }

    public class MultiplicationTable
    {
        public static string GenerateTables()
        {
            string tables = string.Empty;

            for (int firstNumber = 2; firstNumber <= 9; firstNumber++)
            {
                tables += GenerateSingleTable(firstNumber);
            }

            return tables;
        }

        /// <summary>
        /// 生成單一個乘法表, 不必讓外界叫用, 所以宣告為 private
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns></returns>
        private static string GenerateSingleTable(int firstNumber)
        {
            string result = string.Empty;

            for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
            {
                result += $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber,2}\r\n";
            }

            return result + "\r\n";
        }
    }
}