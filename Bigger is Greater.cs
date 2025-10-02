using System;

class Result
{
    public static string biggerIsGreater(string w)
    {
        char[] arr = w.ToCharArray();
        int n = arr.Length;
        
        
        int pivot = -1;
        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] < arr[i + 1])
            {
                pivot = i;
                break;
            }
        }
        
        
        if (pivot == -1)
            return "no answer";
        
        int swapIndex = -1;
        for (int i = n - 1; i > pivot; i--)
        {
            if (arr[i] > arr[pivot])
            {
                swapIndex = i;
                break;
            }
        }
        
        
        char temp = arr[pivot];
        arr[pivot] = arr[swapIndex];
        arr[swapIndex] = temp;
        

        Array.Reverse(arr, pivot + 1, n - pivot - 1);
        
        return new string(arr);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();
            string result = Result.biggerIsGreater(w);
            Console.WriteLine(result);
        }
    }
}
