public class Task
{
    static void sumElements(int[,] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                sum += arr[i,j];
        }
        
        Console.WriteLine("Сумма элементов: " + sum);	
    }

    static void compositionElements(int[,] arr)
    {
        int comp = 1;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                comp *= arr[i,j];
        }
        
        Console.WriteLine("Произведение элементов: " + comp);	
    }

    static void maxElement(int[,] arr)
    {
        int max = arr[0,0];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                if(arr[i,j] > max) max = arr[i,j]; 
        }
        
        Console.WriteLine(" Максимальный элемент: " + max);	
    }

    static void minElement(int[,] arr)
    {
        int min = arr[0,0];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                if(arr[i,j] < min) min = arr[i,j]; 
        }
        
        Console.WriteLine("Минимальный элемент: " + min);	
    }

    static void sumMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        {    	
            int sum = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                sum += arr[i,i];
            
            Console.WriteLine("Сумма элементов главной диагонали: " + sum);	
        }    
    }

    static void compositionMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        { 
            int comp = 1;
            for(int i = 0; i < arr.GetLength(0); i++)
                comp *= arr[i,i];

            Console.WriteLine("Произведение элементов главной диагонали: " + comp);	
        }    
    }

    static void maxMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        { 
            int max = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] > max) max = arr[i,i]; 
    
            Console.WriteLine("Максимальный элемент главной диагонали: " + max);
        }    	
    }

    static void minMainDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        { 
            int min = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] < min) min = arr[i,i]; 
    
            Console.WriteLine("Минимальный элемент главной диагонали: " + min);	
        }    
    }

    static void sumSideDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с побочной диагональю невозможна" );
        else
        { 
            int sum = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                sum += arr[i,arr.GetLength(1) - 1 - i];

            Console.WriteLine("Сумма элементов побочной диагонали: " + sum);
        }    	
    }

    static void compositionSideDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        { 
            int comp = 1;
            for(int i = 0; i < arr.GetLength(0); i++)
                comp *= arr[i,arr.GetLength(1) - 1 - i];
    
            Console.WriteLine("Произведение элементов побочной диагонали: " + comp);
        }    	
    }

    static void maxSideDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        { 
            int max = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] > max) max = arr[i,arr.GetLength(1) - 1 - i]; 
            
            Console.WriteLine("Максимальный элемент побочной диагонали: " + max);
        }    	
    }

    static void minSideDiagonal(int[,] arr)
    {
        if(arr.GetLength(0) != arr.GetLength(1))
		    Console.WriteLine("Матрицы не квадратная. Работа с главной диагональю невозможна" );
        else
        { 
            int min = arr[0,0];
            for(int i = 1; i < arr.GetLength(0); i++)
                if(arr[i,i] < min) min = arr[i,arr.GetLength(1) - 1 - i]; 

            Console.WriteLine("Минимальный элемент побочной диагонали: " + min);
        }	
    }

    static void minInMax(int[,] arr)
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

        Console.WriteLine("Минимальный из максимальных элементов: " + min );	
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
            
            Console.WriteLine("Транспонированная матрица: " );	
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
            
            Console.WriteLine("Результирующий массив: " );	
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

        sumElements(array1);            //сумма элементов
        compositionElements(array1);    //произведение элементов
        maxElement(array1);             //максимальный элемент
        minElement(array1);             //минимальный элемент
        sumMainDiagonal(array1);        //сумма по главной диагонали
        compositionMainDiagonal(array1); //произведение по главной диагонали
        maxMainDiagonal(array1);         //максимальный элемент по главной диагонали
        minMainDiagonal(array1);         //минимальный элемент по главной диагонали
        sumSideDiagonal(array1);         //сумма побочной диагонали
        compositionSideDiagonal(array1); //произведение побочной диагонали
        minSideDiagonal(array1);         //минимальный элемент побочной диагонали
        minInMax(array1);                //минимальный из максимальных
        transposition(array1);           //транспонирование матрицы

        fillArray(array2, 0, 10);
        Console.WriteLine("Исходный массив2: ");
        printArray(array2);

        sumArrays(array1,array2);        //сумма двух матриц
	}
}

