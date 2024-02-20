//СХЕМА
//1.Создать блок для ввода исходного массива строк
//2.Создать блок для инициализации переменных, необходимых для подсчета кол-ва строк
// в новом массиве и создания нового массива.
//3. Следующий блок проверяет каждую строку в исходном массиве на условие <=3 символам
//4. если да, то увеличиваем счетчик количества строк в новом массиве
//5. созлаем новый массив с размером, равным количеству строк, найденом в предыдущем шаге
//6. следующий блок проверяет каждую строку в исходном массиве на условие <=3 символам
//7. если да, добавляет строку в новый массив
//8. блок для вывода нового массива на консоль


string[]originalArray = {"москва","берлин","париж","-2","123","???"};
Console.WriteLine("OriginalArray:" + string.Join(",", originalArray));
int newSize = 0;
foreach(string str in originalArray)
{
    if(str.Length <= 3)
    newSize++;
}
string[]newArray = new string[newSize];
int currentIndex = 0;
foreach(string str in originalArray)
{
    if(str.Length <= 3)
    {
        newArray[currentIndex] = str;
        currentIndex++;
    }
}

 Console.WriteLine("NewArray:" + string.Join(",", newArray));

// Elina@Maxims-MacBook-Pro Task1 % dotnet run
// OriginalArray:москва,берлин,париж,-2,123,???
// NewArray:-2,123,???