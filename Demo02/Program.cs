namespace Demo02
{
    internal class Program
    {
        /// <summary>
        /// 將原本第二層的程式碼抽離成副程式, 避免巢狀迴圈, 比較好閱讀
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int firstNumber = 2; firstNumber <= 9; firstNumber++)
            {
                string table = GenerateSingleTable(firstNumber);
                Console.WriteLine(table);
            }
        }

        /// <summary>
        /// 生成單一個乘法表
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <returns></returns>
        static string GenerateSingleTable(int firstNumber)
        {
            string result = string.Empty;

            for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
            {
                result += $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber,2}\r\n";
            }

            return result;
        }
    }
}