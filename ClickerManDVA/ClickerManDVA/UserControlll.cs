using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public class UserControlll
    {
        public Klava p_Klava = null;
        public Mouse p_Mouse = null;
        public UserControlll()
        {
            this.p_Klava = new Klava(this);
            this.p_Mouse = new Mouse(this);
        }
    }
}
