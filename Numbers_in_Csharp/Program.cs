namespace Numbers_in_Csharp
{
    internal class Program
    {
        public static void DisplayTable(int iNo)
        {
            int iCnt = 0;
            if (iNo < 0)
            {
                iNo = -iNo;
            }
            for (iCnt = 1; iCnt <= 10; iCnt++)
            {
                Console.WriteLine(iNo+" * "+iCnt+" = "+iNo*iCnt);       
            }
        }
        static void Main(string[] args)
        {
            int iValue = 0;
            Console.WriteLine("Enter number :");
            iValue = Convert.ToInt32(Console.ReadLine());

            DisplayTable(iValue);
        }
    }
}