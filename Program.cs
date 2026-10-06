// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);

// }
// System.Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int count = 0;

// foreach (int grade in grades)
// {
//     count += grade;
//     System.Console.WriteLine(grade);
// }
// System.Console.WriteLine($"сумма оценок: {count}");
// System.Console.WriteLine($"средний балл: {count / 5}");

// string[] students = { "Аня", "Ярослав", "Вика"};
// int count1 = 0;
// foreach (string student in students)
// {
//     System.Console.WriteLine(student);
//     count1++;
// }
// System.Console.WriteLine(count1);

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
//     System.Console.WriteLine(points[i]);
// }
// string[] students = { "Аня", "Борис", "Вика"};
// int number = 1;
// foreach (string student in students)
// {
//     System.Console.WriteLine($"{number}.{student}");
//         number++;
// }

//Задание А

// int[] number = { 5, 7, 3, 5, 0 };
// int score = 0;
// foreach (int i in number)
// {
//     score += i;
//     System.Console.WriteLine(i);
// }
// System.Console.WriteLine(score);

// Задание Г
// int[] ball = {4, 6, 8, 3, 11 };
// int max = 0;
// foreach (int h in ball) {
//     if (h > max)
//     {
//         max = h;
//     }
// }
// System.Console.WriteLine($"Максимальная оценка {max}");

// Задание 1
int[] temp = { 5, 3, -11, 6, 9, 21, 0 };
int sum = 0;
foreach (int i in temp)
{
    sum += i;
}
System.Console.WriteLine($"Средняя температура: {sum/temp.Length}");

//Задание 5

string[] book = { "Война и мир", "Муму", "Горе от ума" };
string search = "Муму";
bool flag = false;
foreach (string i in book)
{
    if (i == search)
    {
        flag = true;
    }
}
if (flag == true)
{
    System.Console.WriteLine("Найдено");
}
else
{
    System.Console.WriteLine("Не найдено");
}