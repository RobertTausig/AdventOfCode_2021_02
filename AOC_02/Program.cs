using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AOC_02
{
    class Program
    {
        public static void Main(string[] filePaths)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int horizontal = 0;
            int depth = 0;
            int aim = 0;
            char cmdForward = 'f';
            char cmdDown = 'd';
            char cmdUp = 'u';

            var input = File.ReadAllLines(filePaths[0]);
            foreach (var item in input)
            {
                var instructionVal = (int)item[^1] - 48;
                if (item[0] == cmdForward)
                {
                    horizontal += instructionVal;
                    depth += aim * instructionVal;
                }
                else if (item[0] == cmdDown)
                {
                    aim += instructionVal;
                }
                else if (item[0] == cmdUp)
                {
                    aim -= instructionVal;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("Horizontal: " + horizontal.ToString());
            Console.WriteLine("Depth: " + depth.ToString());
            Console.WriteLine("Multiply: " + (horizontal * depth).ToString());
            Console.WriteLine("Elapsed time [ms]: " + stopWatch.ElapsedMilliseconds.ToString());
        }
    }
}
