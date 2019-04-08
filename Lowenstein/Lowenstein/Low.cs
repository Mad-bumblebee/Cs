using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowenstein
{
    class Low
    {
        string str1, str2;
        public int Lows(string str1, string str2)
        {
            this.str1 = str1;
            this.str2 = str2;

            char s, t;

            int N = str1.Length, M = str2.Length;            

            if (String.Equals(str1,str2)) return 0;

            int[] array = {M, N};           

            if (M == 0 || N == 0) return array.Max();

            int[,] matrix = new int[M + 1, N + 1];

            for (int i = 0; i <= N ; i++) matrix[0, i] = i;           
           
            for (int i = 1; i <= M; i++) matrix[i, 0] = i;
           

            for (int i = 1; i <= N; i++)
            {
                s = str1[i-1];
                
                for (int j = 1,price; j <= M;j++)
                {
                    t = str2[j-1];
                    price = (t == s) ? 0 : 1;
                    
                    matrix[j, i] = Math.Min(Math.Min(matrix[j,i-1] + 1,matrix[j-1,i] +1) ,matrix[j-1,i-1] + Convert.ToInt32(price));
                }
            }          

            return matrix[M,N];
        }  

        public void Levenstein()
        {
            Console.WriteLine(Message(Lows(str1,str2)));
        }

        public string Message(int var)
        {
            return "Рсстояние Левенштейна = " + var;
        }

    }
}
