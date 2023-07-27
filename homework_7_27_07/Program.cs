namespace homework_7_27_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] {"fluutter", "fluuy","fluuinheard"};
            string helpStr = strings[0].Substring(0,1);

            int k = 1;

            bool b = false;
            ///flinhard glomgold
            
            while(true)
            {
                for (int i = 0; i<strings.Length; i++)
                {
                    if (strings[i].Substring(0,k) == helpStr)
                    {
                        b = true;
                    }
                    else
                    {
                        b=false;
                        break;
                    }
                }
                if (b)
                {
                    helpStr += strings[0].Substring(0, k);
                    k++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(k);
        }
        
    }
}