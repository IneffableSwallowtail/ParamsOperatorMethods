using System;
using System.Diagnostics.CodeAnalysis;

public static class Methods
{
    public static int Add(params int[] list)
    {
        list.Append(0);
        int sum = list[0];
        for (int i = 1; i < list.Length; i++)
        {
            sum += list[i] ;
        }
        return sum;
    }
    public static int Subtract(params int[] list)
    {
        list.Append(0);
        int sum = 0;
        sum += list[0];
        for (int i = 1; i < list.Length; i++)
        {
            sum -= list[i];
        }
        return sum;
    }
    public static int Multiply(params int[] list)
    {
        int multiplier = 1;
        for (int i = 0; i < list.Length; i++)
        {
            multiplier *= list[i];
        }
        return multiplier;
    }
    public static int Divide(params int[] list)
    {
        list.Append(1);
        int divider = list[0];
        for (int i = 1; i < list.Length; i++)
        {
            divider /= list[i];
        }
        return divider;
    }
    public static int Modulus(params int[] list)
    {
        list.Append(0); 
        int modulus = list[0];
        for (int i = 1; i < list.Length; i++)
        {
            modulus %= list[i];
        }
        return modulus;
    }
}