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

int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
    System.Console.WriteLine(points[i]);
}
System.Console.WriteLine(points);