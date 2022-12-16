// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число c: ");
double c = Convert.ToDouble(Console.ReadLine());

if(a > b && a > c) {
    Console.WriteLine("max = " + a);
}
if(b > a && b > c) {
    Console.WriteLine("max = " + b);  
}
if(c > a && c > b) {
    Console.WriteLine("max = " + c);    
}
if(b == a && a == c) {
    Console.WriteLine("Числа равны");
}
