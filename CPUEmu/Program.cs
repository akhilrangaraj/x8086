using System;
using x8086;

namespace CPUEmu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            core cpu = new core();
            cpu.debugSetAx(4);
            cpu.debugSetAx(2 << 10);
            Console.ReadKey();
        }
    }
}
