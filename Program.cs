class Program
{
//  static double ratio; -- убираем переменную :)

    static void Main()
    {
//        ratio = largestNumberProcessing();

// если нам нужно посчитать отношение только для элементов 1го и 3го массивов,то 2ой и 4ый массивы убираем за ненадобностью;
// массивы переносим в основной метод; метод largestNumberProcessing убираем

        int[] array1 = new int[3] { 5, 3, -1 };
// переименовали метод; переименовали переменную; поменяли тип переменной на double, так как у отношения должен быть тип double, чтобы, например, можно было без ошибки поделить 5 на 2 при необходимости 
        double maxElement1 = FindMaxElement(ref array1);  

// array3 переименовали в array2, так как массивов осталось всего два
        int[] array2 = new int[3] { -5, -3, -1 };
        double maxElement2 = FindMaxElement(ref array2);

        Console.WriteLine("Ratio of the lagest elements of arrays is {0}", maxElement1 / maxElement2);
    }
  
    /*
     *   static double largestNumberProcessing()  
     *   {
     *       int[] array1 = new int[3] { 5, 3, -1 };
     *       int largestNumber1 = PrintLargestNumber(ref array1);
     *
     *       int[] Array2 = new int[3] { 5214, 1024, 2048 };
     *       int largestNumber2 = PrintLargestNumber(ref Array2);
     *       int[] array4 = new int[0];
     *       int largestNumber4 = PrintLargestNumber(ref array4);
     *       int[] array3 = new int[3] { -5, -3, -1 };
     *       int largestNumber3 = PrintLargestNumber(ref array3);
     *
     *       // compute ratio of first and third largest number
     *       ratio = largestNumber1 / largestNumber3;
     *  }
     */

    static int FindMaxElement(ref int[] array)  // переименовали метод + переписали алгоритм
    {
        int maxElement = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }

        return maxElement;
    }
}
