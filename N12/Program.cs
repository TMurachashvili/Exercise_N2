// 12.	დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივში მხოლოდ იმ ელემენტებს რომლებიც გვხვდება 1 ხელ.
int[] arr12 = { -5, 3, 5, 3, 2, 7, 9, 4, 3, 9, 7 };
int add = Math.Abs(arr12.Min());
int mx = arr12.Max();
int[] newArray = new int[mx + add + 1];


for(int i=0; i< arr12.Length; i++)
{
    newArray[arr12[i]+add]++;
}
Console.Write("Unique Elements of Array :");
for(int i = 0; i< newArray.Length; i++)
{
    if (newArray[i] ==1)
    {
        Console.Write($" {i - add} ");
    }
}