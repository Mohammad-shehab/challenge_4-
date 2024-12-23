

using System;

class MainClass
{

    public static int OneDecremented(int num)
    {
        int count = 0;
        string x = Convert.ToString(num);

        for (int i =1;  i<   x.Length; i++)
        {
            if (x[i -1]-1 == x[i])
                count++;
           
        }
  



        return count;

    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(OneDecremented(987654321));

    }

}