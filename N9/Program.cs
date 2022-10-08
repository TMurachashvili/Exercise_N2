// 9.	დაწერეთ პროგრამა რომელიც მოცემულ მასივს დაბეჭდავს შებრუნებული სახით მაგ 1 2 3 4 —-> 4 3 2 1
int[] arr9 = { 1, 2, 3, 4, 5, 6 };
for(int i = 0; i < arr9.Length; i++)
{
    int x = arr9[i];
    arr9[i] = arr9[arr9.Length - 1-i];
    arr9[arr9.Length - 1 - i] = x;
    if(i== arr9.Length/2-1) { break; }
}
foreach (var elem in arr9) { Console.WriteLine(elem); }
