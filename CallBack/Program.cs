using System;

namespace CallBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            CallBack a = new EatingCallBack();

            h.setCallBack(a);
            a.execute();
        }
    }
}
