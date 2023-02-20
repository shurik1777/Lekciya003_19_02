/*
void Metod1()
{
Console.WriteLine("Автор …");
}
Metod1();
*/
//Первая группа методов - непринимает никаких аргументов и ничего не возвращают.

/*
void Metod2(string msg) //где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.

{
Console.WriteLine(msg); // оператор, в скобках указан принятый аргумент.
}
Metod2("Текст сообщения");
//Это методы, которые ничего не возвращают, но в то же время могут принимать какие-то аргументы.
*/
/*
// Именованные аргументы
//когда у нас явно может быть
//указано какому аргументу, какое значение мы хотим указать. Это часто бывает нужно, если
//методы принимают какое-то количество аргументов, отличное от 1. Продемонстрирую это.
void Metod21(string msg, int count)
{
int i = 0;
while (i < count)
{
Console.WriteLine(msg); // - где переменная count отображает на экране определённое количество сообщений msg.
i++;
}
}
//Metod21("Текст", 4); //- метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4.
Metod21(count: 1, msg: "Текст");
Metod21(count: 3, msg: "Текст3");
Metod21(count: 2, msg: "Текст2"); //Явно указывая наименование аргумента, не обязательно писать их по порядку.
*/
/*
//Третья группа методов
int Metod3()// - не принимает никакие аргументы
{
    return DateTime.Now.Year;// - обязательное использование оператора return, 
    //был косяк в лекции Data вместо Date (или в 2021 было по другому)
}
int year = Metod3();// - вызываем метод, в левой части используем идентификатор
//переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);
*/
/*
// Четвёртая группа методов
// Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.
string Metod4(int count, string text)
{
//int i = 0;
string result = String.Empty;
// while (i<count)
// {
// result = result + text;
// i++;
// }
// return result;
// }
for (int i = 0; i<count; i++)// - вначале ключевое слово, затем инициализация
//счётчика, после проверка условия и инкремент (увеличение счётчика).
{
result = result + text;
}
return result;
}
string res = Metod4(10, "asdf ");
Console.WriteLine(res);
*/
/*
for (int i = 2; i <= 10; i++)
{
for (int j = 2; j <= 10; j++)
{
Console.WriteLine($"{i} * {j} = {i * j}");
}
Console.WriteLine();
}
*/
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
// string newText = Replase(text, ' ', '|');
// Console.WriteLine(newText);
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text,'к','К');
Console.WriteLine(newText);
*/
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // заведём массив, который будем сортировать, int[] arr
void PtintArray(int[] array)//вывод данных массива на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array) // Следующий этап. Нам нужно написать метод, 
// который будет упорядочивать наш массив.Назовём его SelectionSort
{
    for (int i = 0; i < array.Length - 1; i++)//Здесь цикл for, в котором мы пробегаем
    // по всем элементам нашего массива
   //начинаем позицию поиска
//максимального от индекса i+1, где i меняется до максимального значения позиции нашего
//массива, то в этом случае мы должны будем искусственно одну единицу отнять. Тогда
//получится, что ровно это i+1 даст общее количество элементов.
    {
        int minPosition = i; //Назовём её minPosition. И запоминаем позицию рабочего элемента,
        // для которого мы в дальнейшем будем производить какие-то действия
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PtintArray(arr);
SelectionSort(arr);

PtintArray(arr);