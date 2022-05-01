// Задача 1: Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит 
//  число A в натуральную степень B.

int inPower(int a, int x) // число , степень
{
    int res = a;
    if (x == 0) return 1;
    for (int i = 1;i<x;i++){
        res *= a;
    }
    return res;
}

int UserNum = 2;
int UserPow = 8;
Console.WriteLine(inPower(UserNum,UserPow));
