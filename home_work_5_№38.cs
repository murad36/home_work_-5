// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3,21 7,04 22,93 -2,71 78,24] -> 80,95


double[] array = new double[6];
Random rand = new Random();
double hide_max_min(double[] array) {
    int max_2 = 100;
    int min_2 = -100;
    for (int i = 0; i < 6; i++) {
    array[i] = Math.Round(rand.NextDouble() * (max_2 - min_2) + min_2,2);
    }
    
    double max = 0;
    double min = 0;
    for(int j = 0; j < 6 ; j++) {
        if (max < array[j]) {
            max = array[j];
        }
        if (min > array[j]) {
            min = array[j];
        }
    }
Console.WriteLine(min);
Console.WriteLine(max);    
return max-min;   
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {hide_max_min(array)}");

