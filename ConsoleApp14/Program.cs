using System;
namespace program
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            float[] array = new float[n];
            int min = 0;
            int a = -1, b = -1;
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Элемент {0} = ", i);
                array[i] = float.Parse(Console.ReadLine());
                if (array[min] > array[i])
                    min = i;
                if (array[i] < 0)
                {
                    if (a == -1)
                        a = i;
                    else if (b == -1)
                        b = i;
                }
            }
            Console.WriteLine("Номер минимального элемента = {0}", min);
            if (a == -1 || b == -1)
                Console.WriteLine("Недостаточно отрицательных чисел. ");
            else
            {
                float proiz = 1;
                for (int i = a + 1; i < b; i++)
                {
                    proiz *= array[i];
                }
                Console.WriteLine("Произведение между двумя отрицательными числами = {0}", proiz);
            }
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) <= 1)
                {
                    float vrem = array[i];
                    array[i] = array[j];
                    array[j] = vrem;
                    j++;
                }
            }
            Console.WriteLine("Преобразованный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
