using ConsoleApp1._َQuestion_1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Question 1
            //var intRange = new Range<int>(1, 10);
            //Console.WriteLine(intRange.IsInRange(5));


            //var range1 = new Range<int>(1, 10);
            //Console.WriteLine(range1.lengthBetween());



            //#endregion
            #region Question2
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = FindEven.getEven(input);

            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));



            #endregion
        }
    }
}
