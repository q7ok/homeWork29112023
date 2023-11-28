/* Задайте массив из вещественных чисел с ненулевой дробной частью. 
   Найдите разницу между максимальным и минимальным элементов массива.*/

double [] CreateArray (int size) {

    double [] array = new double [size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().NextDouble() * 1000.0 - 500.0;
    }
    return array;
}

void ShowArray (double [] array){

    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindDifference (double [] array) {
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++){
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i];
    }
    double dif = max - min;
    return dif;
}
 

double [] arr = CreateArray(5);
ShowArray(arr);
double difference = FindDifference(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {difference}");



