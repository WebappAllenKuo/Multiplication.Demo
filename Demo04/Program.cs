namespace Demo04
{
    internal class Program
    {
        /// <summary>
        /// 在Demo03的類別裡, 一股惱地把九九乘法表生成並傳回, 缺點是不方便換成不同版面來呈現
        /// 所以, 可以考慮寫一個類別產生"資料", 另一個類別負責排版, 將二者拆開, 在應用上會更靈活
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int firstNumber = 2; firstNumber <= 9; firstNumber++)
            {
                // 得到單一乘法表資訊
                var data = new SingleTable(firstNumber).GetItems();
                foreach (var item in data)
                {
                    Console.WriteLine($"{item.FirstNumber} 乘以 {item.SecondNumber} 等於 {item.Result,2}");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// 單一個項目的資訊
        /// </summary>
        public class MultiplicationItem
        {
            public int FirstNumber { get; }
            public int SecondNumber { get; }

            public MultiplicationItem(int firstNumber, int secondNumber)
            {
                FirstNumber = firstNumber;
                SecondNumber = secondNumber;
            }

            public int Result => FirstNumber * SecondNumber; // 乘積
        }


        /// <summary>
        /// 單一個乘法表的資訊
        /// </summary>
        public class SingleTable
        {
            private readonly int _firstNumber;

            public SingleTable(int firstNumber)
            {
                _firstNumber = firstNumber;
            }

            public IEnumerable<MultiplicationItem> GetItems()
            {
                for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
                {
                    yield return new MultiplicationItem(_firstNumber, secondNumber);
                }
            }
        }
    }
}