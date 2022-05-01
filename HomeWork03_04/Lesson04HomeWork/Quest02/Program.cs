// Задача 2: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.


int SumOfCount(int numeric){
    int Countnumber = 0; // колличество цифр в числе
    int x = numeric; // копия числа
    while (x !=0 ){
        x /=10;        // отсеивание последней цифры 
        Countnumber++; // подсчет 
    }
    int sum = 0; // сумма
    int i = Countnumber;   // корректировка индекса
    while (i>0){
        sum += (numeric%10);  // суммирование из остатка
        numeric /= 10;             // срез последней цифры
        i--;                   
    } 
    return sum;            // возвращение 3й цифры
}


int UserNum = 1522;

Console.WriteLine(SumOfCount(UserNum));



