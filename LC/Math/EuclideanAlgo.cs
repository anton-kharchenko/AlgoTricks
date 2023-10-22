namespace LC.Math;

public class EuclideanAlgo
{
    /// <summary>
    /// Greatest common divisor (GCD) - GCD(a,b) == GCD(b, a%b)
    /// Time - O(log min(a, b))
    /// </summary>
    public int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
    
    /// <summary>
    /// Lowes common divisor (a*b) / GCD(a, b);
    /// Time - O((a*b)  / log min(a, b))
    /// </summary>
    public int Lcm(int a, int b)
    {
        return a * b / Gcd(a, b);
    }
    
    
    /// <summary>
    /// Check Result
    /// Time - O((a*b) / log min(a, b))
    /// </summary>
    public bool CheckResult(int a, int b)
    {
        return a * b == Gcd(a, b) * Lcm(a, b);
    }
}