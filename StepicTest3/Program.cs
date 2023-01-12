using System;
public static class myprogram
{
    static int Do(int a, int b) => a * b;
    static int Do(double a, int b) => (int)(a / b);
    public static void Main()
    {
        float a = 231;
        int b = '2';
        Console.WriteLine(Do(a, b));
    }
}