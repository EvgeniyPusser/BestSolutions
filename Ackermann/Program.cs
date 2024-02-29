
        int Ackermann(uint m, uint n)
        {
            if (m == 0)
                return  (int) (n+1);
            if (m > 0 && n == 0)
                return Ackermann(m - 1, 1);
            if (m > 0 && n > 0)
                return Ackermann(m - 1, (uint)Ackermann(m, n - 1));
            else
            {
                return -1;
            }
        }

        int result = Ackermann(1,2);
        Console.Write(result);
        Console.Write("\n");  