string[]originalArray = {"машина","лес","девочка","дело","три","123"};
Console.WriteLine("OriginalArray:" + string.Join(",", originalArray));
string[]newArray = FilterArrayByLength(originalArray,3);
Console.WriteLine("NewArray:" + string.Join(",", newArray));
static string[]FilterArrayByLength(string[]originalArray, int maxLength)
{
    int count = 0;
    foreach(string str in originalArray)
    {
        if(str.Length <= maxLength)
        {
            count++;
        }
    }
    string[]newArray = new string[count];
    int index = 0;
    foreach(string str in originalArray)
    {
        if(str.Length <= maxLength)
        {
            newArray[index] = str;
            index++;
        }
    }
    return newArray;
}

   
