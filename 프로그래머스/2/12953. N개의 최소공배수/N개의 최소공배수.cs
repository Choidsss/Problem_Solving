public class Solution
{
    public int solution(int[] arr)
    {
        bool flag = false;
        int answer = 0;
        int gcd = 0;
        int lcm = 0;
        int numA = arr[0];
        int numB = arr[1];

        if(arr.Length == 1)
        {
            return arr[0];
        }
        else if (arr.Length == 2)
        {
            flag = true;
        }

        for (int i = 1; i < numA + numB; i++)
        {
            if (numA % i == 0 && numB % i == 0)
            {
                gcd = i;
            }
        }

        lcm = (numA * numB) / gcd;

        if (flag)
        {
            answer = lcm;
            return answer;
        }

        for (int n = 2;n < arr.Length;n++)
        {
            for (int i = 1; i < lcm + arr[n]; i++)
            {
                if (lcm % i == 0 && arr[n] % i == 0)
                {
                    gcd = i;
                }
            }

            lcm = (lcm * arr[n]) / gcd;
        }

        answer = lcm;

        return answer;
    }
}