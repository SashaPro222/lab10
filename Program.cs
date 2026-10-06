string subject = "Программирование";

foreach (char letter in subject)
{
    System.Console.WriteLine(letter);

}
System.Console.WriteLine(subject.Length);

int[] grades = { 4, 5, 3, 5, 4 };
int count = 0;

foreach (int grade in grades)
{
    count += grade;
    System.Console.WriteLine(grade);
}
System.Console.WriteLine($"сумма оценок: {count}");
System.Console.WriteLine($"средний балл: {count/5}");