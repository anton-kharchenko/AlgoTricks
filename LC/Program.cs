using LC.Math;

// var sl = new BinaryPow();
// Console.WriteLine("Recursive version");
// Console.WriteLine(sl.RecursiveExponentiation(2, 7));
// Console.WriteLine("Binary version");
// Console.WriteLine(sl.BinaryExponentiation(2, 7));
// var sl = new BinarySearch();
// Console.WriteLine(sl.IsExists(new []{1,2,3,4,5,6,8}, 6));
// Console.WriteLine(sl.IsExists(new []{-6,1,2,3,4,5,6,8}, 7));
// Console.WriteLine(sl.IsExists(new []{-6,1,2,3,4,5,6,8}, -6));
var sl = new EuclideanAlgo();
Console.WriteLine(sl.Gcd(15, 21));
Console.WriteLine(sl.Lcm(15, 21));
Console.WriteLine(sl.CheckResult(15, 21));

