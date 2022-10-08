// N1
//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიტანს 10 ელემენტს და შეავსებს მასივს. (სცადეთ სხვადასხვა ტიპისთვის)

int[] arr1 = new int[10]; 
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Enter {i+1}th element of array");
    arr1[i] = int.Parse(Console.ReadLine());
}
foreach (var elem in arr1)
{
    Console.WriteLine(elem);
}

// For data type - string

string[] arrStr = new string[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Enter {i + 1}th element of array");
    arrStr[i] = Console.ReadLine();
}
foreach (var strelem in arrStr)
{
    Console.WriteLine(strelem);
}
