﻿/* Задайте массив на 10 целых чисел. Напишите программу, 
   которая определяет количество чётных чисел в массиве. */


int [] CreateArray (int min, int max, int size) {

    int [] array = new int [size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray (int [] array){

    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindEvens (int [] array) {
    int count = 0;
    for ( int i = 0; i < array.Length; i++ ){
        if ((array[i] % 2) == 0) {
            count++;
        }
    }
    return count;
}

int [] arr = CreateArray(1, 100, 10);
ShowArray(arr);
int numbers = FindEvens(arr);
Console.WriteLine($"Количество чётных элементов массива равно: {numbers}");
