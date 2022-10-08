// 10.	დაწერეთ პროგრამა რომელიც მასივიდან დაბეჭდავს უარყოფითი რიცხვების რაოდენობას.

int[] arr10 = { -3, 6, -3, 8, -2, -14, 21 };
int sum = 0;
for(int i = 0; i < arr10.Length; i++)
{
    if (arr10[i] < 0)
    {
        sum++;
    }
}
Console.WriteLine($"{sum} negative numbers in this array");