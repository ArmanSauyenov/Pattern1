using System;
using System.Collections.Generic;
using System.Text;

namespace CallBack
{
    public class Human
    {
        private CallBack cb;
        public void setCallBack(CallBack cb)
        {
            this.cb = cb;
        }
        public void executeAction()
        {
            cb.execute();
        }
    }
}
