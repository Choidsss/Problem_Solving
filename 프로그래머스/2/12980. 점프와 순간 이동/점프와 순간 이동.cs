using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 1;

        while (n > 0)
        {
            if(n == 1)
            {
                break;
            }
            
            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n--;
                answer++;
            }
        }

        return answer;
    }
}