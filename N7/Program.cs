// 7.	მოცემულია მასივი, რომელიც შეგიძლიათ შეავსთ კლავიატურიდანაც და პროგრამიდანაც. 
//დაწერეთ პროგრამა რომელიც დაითვლის ამ მასივში თითოეული ელემენტის რაოდენობას


int[] arr7 = new int[10];
int[] Amount = new int[arr7.Length];
for (int i = 0; i < arr7.Length/2; i++)
{
    Console.WriteLine($"Enter {i + 1}th Element of an Array");
    arr7[i] = int.Parse(Console.ReadLine());
    Amount[i] = -1;
}
for(int i = arr7.Length / 2; i < arr7.Length; i++)
{
    arr7[i] = i + 2;
    Amount[i] = -1;
}

for (int i = 0; i < arr7.Length; i++)
{
    int ctr = 1;
    for (int j = i + 1; j < arr7.Length; j++)
    {
        if (arr7[i] == arr7[j])
        {
            ctr++;
            Amount[j] = 0;
        }
    }

    if (Amount[i] != 0)
    {
        Amount[i] = ctr;
    }
}
Console.WriteLine("Results: ");
for (int i = 0; i < arr7.Length; i++)
{
    if (Amount[i] != 0)
    {
        Console.WriteLine($"Element '{arr7[i]}' - {Amount[i]} times");

    }
}

