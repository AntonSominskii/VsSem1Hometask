// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

if(a > b) {
    Console.WriteLine("max = " + a);
}
if(b > a) {
    Console.WriteLine("max = " + b);
}
if(b == a) {
    Console.WriteLine("Числа равны");
}
