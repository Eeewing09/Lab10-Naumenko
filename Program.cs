// string subject = "Программирование";
// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);

// }
// Console.WriteLine(subject.Length);

// int count = 0;
// int[] grades = { 4, 5, 3, 5, 4 };
// foreach (int grade in grades)
// {
//     count += grade;
//     Console.WriteLine(grade);
// }
// Console.WriteLine(count / grades.Length);

// string[] students = { "Аня", "Ярослав", "Вика" };
// int c = 0;

// foreach (string student in students)
// {
//     c += 1;
//     Console.WriteLine(student);
// }
// Console.WriteLine(c);

// int[] points = { 10, 20, 15 };

// for (int point = 0; point < points.Length; point++)  {
//     points[point] = points[point] + 5;
// }
// Console.WriteLine(points);
// foreach (int point in points) {
//     Console.WriteLine(point);
// }

// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {students}");
//     number++;
// }
// задача А
// int[] mas = { 1, 2, 3, 4, 5 };
// int c = 0;
// foreach (int i in mas)
// {
//     c += i;
//     Console.WriteLine(i);
// }
// Console.WriteLine(c);
// // задача Б
// string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// foreach (string i in week)
// {
//     Console.WriteLine($"{i}!");
// }
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// 5
string[] words = { "Начало", "Старт", "Внимание", "Марш" };
string f_w = "Марш";
bool f = false;
foreach (string i in words)
{
    if (i == f_w)
    {
        f = true;
    }
}
Console.WriteLine(f);
// 7
int[] mas = { 2, 4, 5, 3, 4, 3, 5 };
int c = 0;
foreach (int i in mas)
{
    if (i == 5)
    {
        c += 1;
    }
}
Console.WriteLine(c);
