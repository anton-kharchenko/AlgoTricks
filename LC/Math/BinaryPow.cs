namespace LC.Math;

/// <summary>
/// Binary exponentiation 
/// </summary>
public class BinaryPow
{
    /// <summary>
    ///  if n is odd, function(a, n -1) * a;
    ///  if n is even, function(0(a, n/2) ^ 2) =
    /// </summary>
    /// <param name="a">number</param>
    /// <param name="n">pow</param>
    /// <returns>number in pow</returns>
    public int RecursiveExponentiation(int a, int n) {
        if (n == 0) 
            return 1;
        
        if (n % 2 == 1)
            return RecursiveExponentiation(a, n - 1) * a;
        
        int binPow = RecursiveExponentiation(a, n / 2);
        return binPow * binPow; // ^ 2
    }
    
    /// <summary>
    ///  Example: 13 => 1101 (32_1) => a^13 => (a^2)^3 * (a^2)^2 * (a^2)^0 => 8+4+1
    /// if add operation between our number and 1  equals 1 then we add this to result 
    /// </summary>
    /// <param name="a">number</param>
    /// <param name="n">pow</param>
    /// <returns>number in pow</returns>
    public int BinaryExponentiation(int a, int n)
    {
        int result = 1;
        while (n!=0)
        {
            if ((n & 1)==1)
            {
                result *= a;
            }
            n >>= 1;
            a *= a;
        }
        return result;
    }
}