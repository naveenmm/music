using System;

namespace music
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] major = new int[] { 2,2,1,2,2,2,1 };
            int[] minor = new int[] { 2, 1, 2, 2, 2, 2, 1 };
            int[] Pentatonic_Minor = new int[] { 3, 2, 2, 3, 2 };
            int[] chromatic = new int[] { 1,1,1,1,1,1,1,1,1,1,1,1,1 };
            Console.WriteLine("Enter Scale \n 1.Major \n 2.Minor \n3.Pentatonic Minor Scale \n4.Chromatic");
            string scale=Console.ReadLine();
            string[] b= { "C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};
            Console.WriteLine("Enter value:");
            string val = Console.ReadLine();
            int pos=0;
            int i,j;
            int[] s = new int[13];
            for (i = 0; i < 12; i++)
            {
                if (val == b[i])
                {
                    pos = i;
                }
            }
            Console.Write(b[pos]+" ");

            if (scale == "1")
            {
                for (int k = 0; k < 7; k++)
                {
                    s[k] = major[k];

                }
            }
            else if (scale == "2")
            {
                for (int k = 0; k < 7; k++)
                {
                    s[k] = minor[k];

                }
            }
            else if (scale == "3")
            {
                for (int k = 0; k < 5; k++)
                {
                    s[k] = Pentatonic_Minor[k];

                }
            }
            else 
            {
                for (int k = 0; k < 13; k++)
                {
                    s[k] = chromatic[k];

                }
            }

            for (j = 0; j < 13; j++)
            {
                int s1 = s[j];
                Console.Write(b[(pos + s[j]) % 12] +" ");
                pos = pos + s1;
            }       
        }
    }
}
