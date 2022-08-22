/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1;
int num2;

// ввод данных
Console.WriteLine ("Давайте сравним два числа");
Console.WriteLine ("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
num2 = Convert.ToInt32 (Console.ReadLine());

//сравнение числе и вывод
if (num1 > num2){
    Console.Write (num1 + " больше " + num2 );
}
else{
    Console.Write (num2 + " больше " + num1 );
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1;
int num2;
int num3;

// ввод данных
Console.WriteLine ("Давайте сравним три числа");
Console.WriteLine ("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
num3 = Convert.ToInt32 (Console.ReadLine());

//сравнение числе и вывод
if (num1 > num2){
    if (num1>num3){
        Console.Write ("Самое большое число: " + num1); 
    }
    else{
        Console.Write ("Самое большое число: " + num3);
    }
}
else{
    if (num2>num3){
        Console.Write ("Самое большое число: " + num2);
    }
    else{
        Console.Write ("Самое большое число: " + num3);
    }
}


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//ввод данных
int num1;

Console.WriteLine ("Давайте узнаем четное ли число");
Console.WriteLine ("Введите число: ");

//Определение четности и вывод
num1 = Convert.ToInt32 (Console.ReadLine());
if (num1 % 2 == 0) {
    Console.WriteLine("Четное");
}
else {
    Console.WriteLine("Нечетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//ввод данных
int N;
int current = 2;

Console.WriteLine ("Давайте узнаем четное ли число");
Console.WriteLine ("Введите число: ");
N = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Четные числа от 1 " + "до " + N + " ");

//Определение четности и вовод данных
while (current < N){
    
    Console.Write (current+ " ");
    current = current + 2;
}
