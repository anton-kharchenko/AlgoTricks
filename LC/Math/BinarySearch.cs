namespace LC.Math;

public class BinarySearch
{
    public bool IsExists(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left<= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return true;
            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}