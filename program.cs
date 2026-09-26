using System;
class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        p.ExceptionSample();
    }

    private void ExceptionSample()
    {
        int i=0;
        while (i < 100)
        {
            if (i == 60)
            {
                try
                {
                    throw new ArgumentException();
                }
                catch (Exception)
                {
                }
            }
            else
            {
                try
                {
                    throw new OutOfMemoryException();
                }
                catch (Exception)
                {
                }
            }
            i++;
        }
    }
}
