namespace Numbers_in_Csharp
{
    internal class Program
    {
        public static int facts(int iNo)
        {
            int iMult = 1;
            if (iNo < 0)
            { iNo = -iNo; }

            while (iNo > 0)
            {
                iMult = iMult * iNo;
                iNo--;
            }
            return iMult;
        }
    
        static void Main(string[] args)
        {
            int iValue = 0;
            int iRet = 0;

            Console.WriteLine("Enter number");
            iValue = Convert.ToInt32(Console.ReadLine());
            iRet = facts(iValue);
            Console.WriteLine("Result is : " +iRet);

        }
    }
}