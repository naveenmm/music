using System;

namespace music
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Scale name::");
            var scale = new Scales();
            string name=Console.ReadLine();
            scale.name = name;
            double sequence=scale.getsequence(name);
            Console.WriteLine(sequence);
            int[] s = scale.note(sequence);
            //for(int i=0;i<s.Length;i++)
            //{
            //    Console.WriteLine(s[i]);
            //}                                        
            //string[] b= { "C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};
            Console.WriteLine("Enter start value:");
            string val = Console.ReadLine();
            scale.show(val,s);
                        
            
        }
    }
}
