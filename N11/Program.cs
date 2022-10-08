// 11.	დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივში უნიკალურ ელემენტებს
//( მაგ 1 1 1 2 2 3  4—> 1 2 3 4) მასივის შევსება როგორც გინდა მოახდინეთ.
int[] arr11 = { 3, 5, 3, 2, 7, 9, 4, 3, 9, 7 };
for (int i = 0; i < arr11.Length; i++)
{
    bool Unique = true;
    for (int j = 0; j < i; j++)
    {
        if (arr11[i] == arr11[j]) { Unique = false; break; }
    }
    if (Unique) { Console.Write(arr11[i]); }
}
