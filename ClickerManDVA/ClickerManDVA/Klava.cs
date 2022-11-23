
using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace System
{
    public partial class Klava
    {
        public Klava() { }
        public Klava(UserControlll Sender) { this.p_Sender = Sender; }
        public UserControlll p_Sender = null;
        
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public int p_SleepTime = 50;
        public Klava Sleep(System.Nullable<int> _Sleep = null) 
        {
            if (_Sleep != null) this.p_SleepTime = _Sleep.Value;
            System.Threading.Thread.Sleep(this.p_SleepTime);
            return this;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public Klava Down(byte nVirtKey) { keybd_event(nVirtKey, 0, 0, 0); return this.Sleep(); }
        public Klava Up(byte nVirtKey) { keybd_event(nVirtKey, 0, 2, 0); return this.Sleep(); }
        public System.Boolean Is(int nVirtKey) { switch (GetKeyState(nVirtKey)) { case -127: return true; break; case -128: return true; break; default: return false; break; } return false; }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>System.Klava.Test();</summary>
        public static void Test()
        {
            var qwe = new System.UserControlll()
                .p_Klava
                    .Q_Is(x => System.Console.WriteLine("true"), x => System.Console.WriteLine("false"))
                    .Q_Down()
                    .Q_Is(x => System.Console.WriteLine("true"), x => System.Console.WriteLine("false"))
                    .Q_Up()
                    .Q_Is(x => System.Console.WriteLine("true"), x => System.Console.WriteLine("false"))
                .p_Sender
                .p_Klava
            ;
        }
        

    }
}

