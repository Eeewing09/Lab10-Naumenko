string subject = "Программирование";
foreach (char letter in subject)
{
    Console.WriteLine(letter);

}
Console.WriteLine(subject.Length);

int count = 0;
int[] grades = { 4, 5, 3, 5, 4 };
foreach (int grade in grades)
{
    count += grade;
    Console.WriteLine(grade);
}
Console.WriteLine(count / grades.Length);