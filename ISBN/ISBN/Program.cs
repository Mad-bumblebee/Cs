using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер ISBN");
            string str = Console.ReadLine();

            //string str = "979-0-66003-540-5";            

            ISBN obj = new ISBN(str);

            Console.WriteLine(obj.Сheck());
          
            Console.ReadKey();
        }
    }

    class ISBN
    {
        public string str;
        int[] arr;
        public ISBN(string str)
        {
            this.str = Stroke(str);           

        }

        public string Сheck()
        {
            string non = "Неверный формат!";

            switch (str.Length)
            {
                case 10:
                   return ISBN_10() ? "Ваш формат : ISBN-10" : non;                    
                case 13:
                   return ISBN_13() ? "Ваш формат : ISBN-13" : non;                    
                default:
                   return non;                    
            }
        }

        public string Stroke(string str)
        {
            this.str = str;
            return str = String.Join("", str.Split('-', ' '));
        }

        public bool ISBN_10()
        {
            arr = new int[str.Length];
            int sum = 0;
            for (int i= 0; i < arr.Length; i++)
            {
                int.TryParse(Convert.ToString(str[i]), out arr[i]);               
            }
            
            for (int i = 0, k = arr.Length; i <= arr.Length - 2; k--, i++)
            {                
                    sum += arr[i] * k;
            }           
            return (sum += Convert.ToInt32(arr[arr.Length - 1])) % 11 == 0 ? true : false;                 

        }
        public bool ISBN_13()
        {
            arr = new int[str.Length];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int.TryParse(Convert.ToString(str[i]), out arr[i]);                
            }

            for (int i = 0, k = 1; i <= arr.Length - 1; k++, i++)
            {
                if (k % 2 == 0)
                {
                    sum += arr[i] * 3;
                }
                else sum += arr[i];
            }         
              
            return sum % 10 == 0 && arr[0] == 9 && arr[1] == 7 && (arr[2] == 8 || arr[2] == 9) ? true : false;                     
        }
    }
}
