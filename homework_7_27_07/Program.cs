namespace homework_7_27_07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] str = { "havke", "haze", "havhe" };
            int k = 1;
            while (check(str, k))
            {
                k++;
            }
            Console.WriteLine(k-1);

        }
        static bool check(string[] str, int k)
        {
            string help = str[0].Substring(0, k);
            foreach (var i in str)
            {
                if (i.Substring(0, k)!= help)
                {
                    return false;
                }
            }
            return true;
        }

    }
}