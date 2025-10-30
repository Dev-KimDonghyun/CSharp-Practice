using System; // import function

namespace Sharp // namespace > class
{
    public class Utility
    {
        public void Greet()
        {
            Console.WriteLine("Utility Class의 Greet 매서드 호출됨");
        }

        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Main 함수에서 함수 실행 ---");

            Utility myFunctions = new Utility();

            myFunctions.Greet();

            int numOne = 12;
            int numTwo = 3;

            int result = myFunctions.Multiply(numOne, numTwo);

            Console.WriteLine($"{numOne} * {numTwo} = {result}");
            Console.WriteLine("--- 모든 함수 실행 완료 ---");
        }
    }
}