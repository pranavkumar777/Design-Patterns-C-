using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{

    interface IAlgorithms
    {
        void sort(int[] a);
    }

    class BubbleSort : IAlgorithms
    {
        public void sort(int[] arr)
        {
            Console.WriteLine("Bubble Sort");
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }

    class InsertionSort: IAlgorithms
    {
        public void sort(int[] arr)
        {
            Console.WriteLine("Insertion Sort");
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

            
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

    }

    class Client
    {
        IAlgorithms algorithm;
        public Client(IAlgorithms algorithm)
        {
            this.algorithm = algorithm;
        }

        public void sort(int[] a)
        {
            algorithm.sort(a);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 213, 33,66,23,222,99,123456,56 };
            IAlgorithms algorithm1 = new BubbleSort();
            Client client1 = new Client(algorithm1);
            client1.sort(a);

            IAlgorithms algorithm2 = new InsertionSort();
            Client client2 = new Client(algorithm2);
            client2.sort(a);

            Console.Read();

        }
    }
}
