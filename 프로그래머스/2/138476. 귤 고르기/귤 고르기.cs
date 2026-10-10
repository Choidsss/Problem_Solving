using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        List<int> list = new List<int>();
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int answer = 0;

        for (int i = 0; i < tangerine.Length; i++)
        {
            if (dic.ContainsKey(tangerine[i]))
            {
                dic[tangerine[i]]++;
            }
            else
            {
                dic.Add(tangerine[i], 1);
            }
        }

        foreach (var pair in dic.OrderByDescending(x => x.Value))
        {
            k -= pair.Value; 
            answer++;        

            if (k <= 0)      
            {
                break;
            }
        }

        return answer;
    }
}