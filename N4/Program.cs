// 4.დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოტანილი რიცხვისთვის 
//დაითვლის 1-დან n მდე ამ რიცხვების კვადრატების ჯამს.
Console.WriteLine("Enter Number");
string num4 = Console.ReadLine();
int num4Int = int.Parse(num4);
int SquareSum = 0;
for (int i = 0; i <= num4Int; i++) 
{
    int square = i*i;
    SquareSum += square;
}
Console.WriteLine(SquareSum);