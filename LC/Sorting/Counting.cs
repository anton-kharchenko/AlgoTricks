namespace LC.Sorting;

public class Counting
{
    public void Sort(int[] arr)
    {
        int[] counters = new int[arr.Max() + 1];
        foreach (var element in arr)
        {
            counters[element] += 1;
        }

        int index = 0;
        for (int i = 0; i<counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                arr[index] = i;
                index++;
            }
        }
    }
}