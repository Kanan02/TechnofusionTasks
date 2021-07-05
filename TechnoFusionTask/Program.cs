using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoFusionTask
{
    class Program
    {
        
		static bool isPrime(int num)
        {
			for (int i = 2; i <= num / 2; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		static int[] deleteDuplicate(int[]arr)
        {
			int len = arr.Length;
			int[] temp = new int[len];
            int j = 0;
            if (len==0||len==1)
            {
                return arr;
            }
            //to create array with unique elements
            for (int i = 0; i < len-1; i++)
                if (arr[i] != arr[i + 1])
                    temp[j++] = arr[i];
            temp[j++] = arr[len - 1];
            
            
            //to narrow the size
            int[] final_arr=new int[j];
            for (int i = 0; i < j; i++)
            {
                final_arr[i] = temp[i];
            }

            return final_arr;
        }
		
		static void Main(string[] args)
        {
            #region Task1

            Console.WriteLine("Task 1");
            int num = 2,count=0;

			long sum = 0;
			while (count < 1000)
			{
				if (isPrime(num))
				{
                    
					sum += num;
					count++;
				}
				num++;
			}
            Console.WriteLine($"Sum is: {sum}");
			
            #endregion


            #region Task2

            Console.WriteLine("Task 2");
			int[] arr1 = new int[] { 2, 3, 6, 6, 8, 9, 10, 10, 10, 12, 12 };
			int[] arr2 = deleteDuplicate(arr1);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine();
            #endregion


            #region Task3

            Console.WriteLine("Task 3\nEnter the string:");
            string str = Console.ReadLine();
            int upperc = 0,lowc=0,dig=0,other=0,len=str.Length;
            for (int i = 0; i < len; i++)
            {
                
                if (char.IsUpper(str[i])) upperc++;
                else if (char.IsLower(str[i])) lowc++;
                else if (char.IsDigit(str[i])) dig++;
                else other++;
            }
            Console.WriteLine($"Number of uppercase letters is: {upperc}. So percetange is {Math.Round((double)upperc/len*100,2)}%");
            Console.WriteLine($"Number of lowercase letters is: {lowc}. So percetange is {Math.Round((double)lowc / len*100,2)}%");
            Console.WriteLine($"Number of digits is: {dig}. So percetange is {Math.Round((double)dig/len*100,2)}%");
            Console.WriteLine($"Number of other characters is: {other}. So percetange is {Math.Round((double)other/len*100,2)}%");
            
            #endregion
        }
    }
}
