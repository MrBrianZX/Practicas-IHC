using System;

public class Practica2
{
    public static void Main (string[]args){
        int[] Input = new int[]{ 2, 7, 11, 15 };
        int target = 18;
        int[] Output = new int[2];
        Output = SumaDos (Input, target);
        Console.WriteLine ("(" + Output[0] + "," + Output[1] + ")");
    }

    public static int[] SumaDos (int[]Input, int target){
        int[] Output = new int[2]{-1,-1};
        int i, j, size, flag;
        i = 0;
        flag = 0;
        size = Input.Length;
        do{
            j = i;
            while (flag == 0 && j < size){
                if ((Input[i] + Input[j]) == target){
                    flag = 1;
                    Output[0] = i;
                    Output[1] = j;
                }
                j++;
            }
            i++;
        }while (flag == 0 && i < size);
        return Output;
    }
}