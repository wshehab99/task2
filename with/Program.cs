using System;

namespace with
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int col = int.Parse(Console.ReadLine());
            float[,] array = new float[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("enter the value of array[{0},{1}]",i,j);
                    array[i, j] = float.Parse(Console.ReadLine());
                }
            }
            float[] payOffs = new float[col];
            for (int i = 0; i < col; i++)
            {
                Console.WriteLine("enter the value of pay of model [{0}]", i);
                payOffs[i] = float.Parse(Console.ReadLine());
            }
            EV(array, payOffs);
            EVP(array, payOffs);
        }
        static void EV(float[,] array,float[] payOffs)
        {
            float[] evm =new float[array.GetLength(0)];
            for (int i = 0; i < evm.Length; i++)
            {
                evm[i] = 0;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    
                    evm[i] += array[i, j] * payOffs[j];
                }
            }
            float max = evm[0];
            for (int i = 0; i < evm.Length; i++)
            {
                if (evm[i]>max)
                {
                    max = evm[i];
                }
            }
            Console.WriteLine("EVM of = {0}",max);
        }
    static void EVP(float[,] array, float[] payOffs)
        {
            float[] evm = new float[array.GetLength(0)];
            
            for (int i = 0; i < evm.Length; i++)
            {
                evm[i] = 0;
            }
           

            for (int i = 0; i < array.GetLength(0); i++)
            {
               
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    
                    evm[i] += array[i, j] * payOffs[j];
                }
                
            }
            float max = evm[0];
            for (int i = 0; i < evm.Length; i++)
            {
                if (evm[i] > max)
                {
                    max = evm[i];
                }
            }
            float[] maxValues = new float[array.GetLength(1)];
            float mm;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                mm = array[0, i];
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[j, i] > mm) { mm = array[j, i]; }
                }
                maxValues[i] = mm;
            }
            float result = 0;
            for (int i = 0; i < maxValues.Length; i++)
            {
                result += maxValues[i] * payOffs[i];
            }
            float evmp = result - max;
            Console.WriteLine("The EVMP of the model is : {0}",evmp);
        }
    }
}
