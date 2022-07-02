using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    public static class BinaryGap
    {
        public static int Solution(int N)
        {

            int answer = 0;
            string binary = Convert.ToString(N, 2);
            int bilen = binary.Length;
            int maxlen = 0;
            Char[] ch = binary.ToCharArray();


            for (int i = 0; i <= bilen - 1; i++)
            {

                if (ch[i].ToString() == "0")
                {
                    maxlen += 1;

                }
                else
                {
                    if (maxlen > answer)
                    {
                        answer = maxlen;
                    }
                    maxlen = 0;
                }
            }

            return answer;

        }
    }
}
