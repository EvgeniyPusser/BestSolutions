﻿

        int Ackermann(int m, int n)
        {
            if (m == 0)
                return (n+1);
            if (m > 0 && n == 0)
                return Ackermann(m - 1, 1);
            if (m > 0 && n > 0)
                return Ackermann(m - 1, Ackermann(m, n - 1));
            else
            {
                return -1;
            }
        }

        int result = Ackermann(0,8);
        Console.Write(result);
        Console.Write("\n");   