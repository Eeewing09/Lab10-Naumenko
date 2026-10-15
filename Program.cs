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

int[] points = { 10, 20, 15 };

for (int point = 0; point < points.Length; point++)  {
    points[point] = points[point] + 5;
}
Console.WriteLine(points);
foreach (int point in points) {
    Console.WriteLine(point);
}

