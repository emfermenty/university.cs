using System;

class Program{
    public static void Main(){
        bool s = true;
        Array<int> a = null;
        while(s){
        try{
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("И столбцов: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Вывод первого задания: ");
        a = new Array<int>(n,m);
        a.firstarr(n,m);
        s = false;
        } catch {
            Console.WriteLine("неверные данные");
            }
        }
        s = true;
        Array<int> b = null;
        while(s){
            try{
            Console.WriteLine("Введите размерность массива N x N: ");
            int nn = int.Parse(Console.ReadLine());
            Console.WriteLine("Вывод второго задания: ");
            b = new Array<int>(nn);
            s = false;
            } catch{
                Console.WriteLine("неверные данные");
            }
        } s = true;
        Array<int> c = null;
        while(s){
            try{
                Console.WriteLine("Введите размерность массива: ");
                int nnn = int.Parse(Console.ReadLine());
                int nnnn = int.Parse(Console.ReadLine());
                Console.WriteLine("Выведте значение x: ");
                int x = int.Parse(Console.ReadLine());
                c = new Array<int>(nnn, nnnn, x);
                s = false;
            } catch{
                Console.WriteLine("Неверные данные");
            }
        }
        //задание 2
        s = true;
        while(s){
            Array<bool> z = new Array<bool>();
            s = false;
        }
        //задание 3
        Console.WriteLine("Транспонировка ");
        a.Transpose();
        
        Array<int> d = null;
        d = a + b - (c * 3);
        Console.WriteLine(d.ToString());
    }
}
