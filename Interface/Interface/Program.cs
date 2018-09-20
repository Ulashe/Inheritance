using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class A
    {
        protected int x;
        protected int y;
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
    }
    public interface B
    {
        int get(int z); 
    }
    class C : A, B
    {
        public int getXY()
        {
            return x * y;
        }
        public int get(int z)
        {
            return z * 50;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var nw = new C();
            nw.setX(6);
            nw.setY(7);
            Console.WriteLine("getXY: {0}\nget: {1}", nw.getXY(), nw.get(5));
            Console.ReadLine();
        }
    }
}
