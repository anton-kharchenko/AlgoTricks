using LC.Sorting;

var c = new Counting();
var arr = new int[] { 3, 65, 7, 12, 8, 1, 22, 10, 96 };
c.Sort(arr);
foreach (var item in arr)
{
    Console.WriteLine(item);
}
