using System;
public class Task
{
    static int sumElements(int[,] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                sum += arr[i,j];
        }
        return sum;
    }

    static int compositionElements(int[,] arr)
    {
        int comp = 1;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                comp *= arr[i,j];
        }
        return comp;
    }

    static int maxElement(int[,] arr)
    {
        int max = arr[0,0];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                if(arr[i,j] > max) max = arr[i,j]; 
        }
        return max;
    }

    static int minElement(int[,] arr)
    {
        int min = arr[0,0];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                if(arr[i,j] < min) min = arr[i,j]; 
        }
        return min;
    }

    static string sumMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    return ("Матрицы не квадратная. Работа с главной диагональю невозможна") ;
        else
        {   
            int sum = 0; 	 
            for(int i = 0; i < arr.GetLength(0); i++)
                sum += arr[i,i];

            return sum.ToString(); 	
        }   
    }

    static string compositionMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
            return ("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        { 
            int comp = 1;
            for(int i = 0; i < arr.GetLength(0); i++)
                comp *= arr[i,i];

            return comp.ToString();	
        }    
    }

    static string maxMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
            return ("Матрицы не квадратная. Работа с главной диагональю невозможна" );  
        else
        { 
            int max = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] > max) max = arr[i,i]; 
            
            return max.ToString();  
        }   	
    }

    static string minMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
            return("Матрицы не квадратная. Работа с главной диагональю невозможна" );
  
        else
        { 
            int min = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] < min) min = arr[i,i]; 
    	
            return min.ToString();
        }    
    }

    static string sumSideDiagonal(int[,] arr)
    {
        

        if(arr.GetLength(0) != arr.GetLength(1))
		    return ("Матрицы не квадратная. Работа с побочной диагональю невозможна" );

        else
        { 
            int sum = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                sum += arr[i,arr.GetLength(1) - 1 - i];
            
            return sum.ToString();	
        }    
    }

    static string compositionSideDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
            return ("Матрицы не квадратная. Работа с главной диагональю невозможна" );
  
        else
        { 
            int comp = 1;
            for(int i = 0; i < arr.GetLength(0); i++)
                comp *= arr[i,arr.GetLength(1) - 1 - i];
    
            return comp.ToString();
        }    	
    }

    static string maxSideDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
            return ("Матрицы не квадратная. Работа с главной диагональю невозможна" );
   
        else
        { 
            int max = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] > max) max = arr[i,arr.GetLength(1) - 1 - i]; 
            
             return max.ToString();
        }    	
    }

    static string minSideDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
            return("Матрицы не квадратная. Работа с главной диагональю невозможна" );
   
        else
        { 
            int min = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] < min) min = arr[i,arr.GetLength(1) - 1 - i]; 

            return min.ToString();
        }	
    }

    static int minInMax(int[,] arr)
    {
        int[] arrayMax = new int[arr.GetLength(0)];
        int min = 0;
        
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            arrayMax[i] = arr[i,0];
            for(int j = 0; j < arr.GetLength(1); j++)
                if(arr[i,j] > arrayMax[i]) arrayMax[i] = arr[i,j]; 
        }
        
        min = arrayMax[0];
        for(int i = 1; i < arr.GetLength(0); i++)
            if(arrayMax[i] < min) min = arrayMax[i]; 

        return min;
    }

   static void transposition(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1)) 
            Console.WriteLine("Транспонирование невозможно. Матрица не вадратная. ");
        else
        {
            int t = 0;
            for(int i = 1; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < i; j++)
                {
                    t = arr[i,j];
                    arr[i,j] = arr[j,i];
                    arr[j,i] = t;
                }
            }
            printArray(arr);
        }
    }

    static void sumArrays(int[,] arr1, int[,] arr2)
    {	
        if(arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1))
            Console.WriteLine("Матрицы разной размерности. Суммирование невозможно" );
            	
        else
        {	
            int[,] resultArray = new int[arr1.GetLength(0),arr1.GetLength(1)];

            for(int i = 0; i < arr1.GetLength(0); i++)
            {
                for(int j = 0; j < arr1.GetLength(1); j++)
                    resultArray[i,j] = arr1[i,j] + arr2[i,j] ;
            }
            printArray(resultArray);
        }
    }

    static void printArray(int[,] arr)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                Console.Write(String.Format("{0,4}", arr[i,j]));
            Console.WriteLine();	
        }	
    }
    static void fillArray(int[,] arr, int startEl, int endEl)
    {
        Random rnd = new Random();
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                arr[i,j] = rnd.Next(startEl, endEl + 1);
        }

    }
	static void Main()
	{
        Console.WriteLine("Введи кол-во строк массивов: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи кол-во столбцов массивов: ");
        int n = int.Parse(Console.ReadLine());

        int[,] array1 = new int[m,n];
        int[,] array2 = new int[m,n];
        fillArray(array1, 0, 10);

        Console.WriteLine("Исходный массив1: ");
        printArray(array1);

        Console.WriteLine("Cумма элементов: " + sumElements(array1));             //сумма элементов
        Console.WriteLine("Произведение элементов: " + compositionElements(array1));     //произведение элементов
        Console.WriteLine("Максимальный элементов: " + maxElement(array1));             //максимальный элемент
        Console.WriteLine("Минимальный элементов: " + minElement(array1));             //минимальный элемент
        Console.WriteLine("Сумма элементов главной диагонали: " + sumMainDiagonal(array1));        //сумма по главной диагонали
        Console.WriteLine("Произведение элементов главной диагонали: " + compositionMainDiagonal(array1)); //произведение по главной диагонали
        Console.WriteLine("Максимальный элемент главной диагонали: " + maxMainDiagonal(array1));         //максимальный элемент по главной диагонали
        Console.WriteLine("Минимальный элемент главной диагонали: " + minMainDiagonal(array1));         //минимальный элемент по главной диагонали
        Console.WriteLine("Сумма элементов побочной диагонали: " + sumSideDiagonal(array1));        //сумма побочной диагонали
        Console.WriteLine("Произведение элементов побочной диагонали: " + compositionSideDiagonal(array1)); //произведение побочной диагонали
        Console.WriteLine("Минимальный элементов побочной диагонали: " + minSideDiagonal(array1));         //минимальный элемент побочной диагонали
        Console.WriteLine("Минимальный из максимальных элементов: " + minInMax(array1));                //минимальный из максимальных
        
        Console.WriteLine("Транспонированная матрица: " );
        transposition(array1);            //транспонирование матрицы

        fillArray(array2, 0, 10);
        Console.WriteLine("Исходный массив2: ");
        printArray(array2);

        Console.WriteLine("Сумма двух матриц: "); //сумма двух матриц 
        sumArrays(array1,array2);     
	}
}

