int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
birdsPerDay.FirstOrDefault(e => e >= 5);
foreach (var item in birdsPerDay)
{
    System.Console.WriteLine(item);
}