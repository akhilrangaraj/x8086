using System;
using System.Collections.Generic;
using System.Text;

namespace x8086
{
    public class core
    {
        private List[] registers_8 = new List["ah", "al"];
        private String[] registers_16 = ["ax"];
        // A Registers
        private byte ah;
        private byte al;
        private ushort ax
        {
            get {
                return (ushort)((ah << 8) + al);
            }
            set
            {
                this.ah = (byte)(value >> 8);
                this.al = (byte)(value);
            }
        }
        public core()
        {
            this.ax = 0;
            this.ah = 0;
            this.al = 0;
        }
        public void debugSetRegister(String register, ushort value)
        {
            var reg = typeof(core).GetField(register).;
            Console.WriteLine($"Value of ax is {ax} - {ah} {al}");
        }
    }
}
