public class Solution
{
    public long solution(int n)
    {
        long answer = 0;
        int[] arr = new int[n];
        arr[0] = 1 % 1234567;

        for (int index = 0;index < n;index++)
        {
            if (index == 0)
            {
                continue;
            }
            else if(index == 1)
            {
                arr[index] = 2 % 1234567;
                continue;
            }

            arr[index] = (arr[index - 2] + arr[index - 1]) % 1234567;
        }

        answer = (long)arr[arr.Length - 1] % 1234567;

        return answer;  
    }
}