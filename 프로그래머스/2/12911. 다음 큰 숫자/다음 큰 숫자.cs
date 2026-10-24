using System;

class Solution
{
    public int solution(int n)
    {
        int answer = n + 1;
        int num = n;
        int addValue = 1;
        int tempCnt = 0;
        int cntOne = 0;

        bool flag = false;

        if (num % 2 == 0)
        {
            flag = false;
        }
        else
        {
            flag = true;
        }

        while (true)
        {
            num = num / 2;

            if (num % 2 != 0)
            {
                tempCnt++;
            }

            if (num / 2 == 0)
            {
                break;
            }
        }

        if (flag)
        {
            tempCnt++;
        }

        if (answer % 2 != 0)
        {
            flag = true;
        }
        else
        {
            flag = false;
        }

        while (true)
        {
            answer = answer / 2;

            if (answer % 2 != 0)
            {
                cntOne++;
            }

            if (answer / 2 == 0)
            {
                if (flag)
                {
                    cntOne++;
                }

                if (cntOne == tempCnt)
                {

                    break;
                }
                else
                {
                    addValue++;
                    answer = n + addValue;
                    cntOne = 0;

                    if (answer % 2 != 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
        }

        return answer = n + addValue;
    }
}