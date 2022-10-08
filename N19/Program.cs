// A. Boy or Girl
/*This is his method: if the number of distinct characters in one's user name is odd, 
then he is a male, otherwise she is a female. You are given the string that denotes the user name, 
please help our hero to determine the gender of this user by his method.
If it is a female by our hero's method, print "CHAT WITH HER!" (without the quotes), otherwise, print "IGNORE HIM!" (without the quotes).
 */
string str19 = "sevenkplus";
int UniqueLength = 0;
for (int i = 0; i <= str19.Length - 1; i++)
{
    bool isDuplicate = false;
    for (int j = 0; j < i; j++)
    {
        if (str19[i] == str19[j]) { isDuplicate = true; break; }
    }

    if (!isDuplicate) { UniqueLength++; }

}

if (UniqueLength % 2 == 0) { Console.WriteLine("CHAT WITH HER!"); }
else Console.WriteLine("IGNORE HIM!");