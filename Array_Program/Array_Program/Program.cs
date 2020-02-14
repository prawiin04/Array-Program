using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("Enter size of Array to be created : ");
            int arr_size = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[arr_size];

            for(int i=0; i<arr_size; i++)
            {
                Console.Out.Write("Element Number {0} : ", i);
                arr[i] = Console.ReadLine();
            }

            Console.Out.Write("The Array Elements are : \n");
            for(int i=0; i<arr_size; i++)
            {
                Console.Out.WriteLine(arr[i]);
            }
            Console.Out.Write("\nEnter 'y' to update the array or else press any button to exit\n");

            bool quit = false;
            while(!quit)
            {
                if(Console.KeyAvailable)
                    if(Console.ReadKey().KeyChar == 'y')
                    {
                        try 
                        {  
                        Console.Out.Write("\nEnter the Element index to update : ");
                        int z = 0;
                        z = Convert.ToInt32(Console.ReadLine());
            
                        Console.Out.Write("\nEnter the Element to update\n");
                        arr[z] = Convert.ToString(Console.ReadLine());
                        }
                        catch(Exception ex)
                        {
                            Console.Out.Write("\nEnter correct index value!!!\n");
                            Console.Out.Write("\nEnter 'y' to update the array or else press any button to exit\n");
                        }
                    
                    }
                    else
                    {
                        Console.Out.Write("\nThe Array Elements are\n");
                        for(int i=0; i<arr_size; i++)
                        {
                            Console.Out.WriteLine(arr[i]);
                            
                        }
                        
                        Console.Out.Write("Press 'Enter' to exit");
                        Console.ReadLine();
                        quit = true;
                        Console.ReadKey();
                    }
            }
        }
    }
}
