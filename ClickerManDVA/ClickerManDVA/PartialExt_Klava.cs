
using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace System
{
    public partial class Klava
    {   
#region 65 A
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>A_Down</summary><returns></returns>
    public Klava A_Down() { keybd_event(65, 0, 0, 0); return this.Sleep(); }
    /// <summary>A_Up</summary><returns></returns>
    public Klava A_Up() { keybd_event(65, 0, 2, 0); return this.Sleep(); }
    /// <summary>A_Up_Down</summary><returns></returns>
    public Klava A {get{this.A_Down().A_Up(); return this.Sleep();}}
    /// <summary>_Is_A_Down</summary><returns></returns>
    public System.Boolean A_Is(){return this.Is(65);}
    /// <summary>if(A_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava A_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.A_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 66 B
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>B_Down</summary><returns></returns>
    public Klava B_Down() { keybd_event(66, 0, 0, 0); return this.Sleep(); }
    /// <summary>B_Up</summary><returns></returns>
    public Klava B_Up() { keybd_event(66, 0, 2, 0); return this.Sleep(); }
    /// <summary>B_Up_Down</summary><returns></returns>
    public Klava B {get{this.B_Down().B_Up(); return this.Sleep();}}
    /// <summary>_Is_B_Down</summary><returns></returns>
    public System.Boolean B_Is(){return this.Is(66);}
    /// <summary>if(B_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava B_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.B_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 67 C
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>C_Down</summary><returns></returns>
    public Klava C_Down() { keybd_event(67, 0, 0, 0); return this.Sleep(); }
    /// <summary>C_Up</summary><returns></returns>
    public Klava C_Up() { keybd_event(67, 0, 2, 0); return this.Sleep(); }
    /// <summary>C_Up_Down</summary><returns></returns>
    public Klava C {get{this.C_Down().C_Up(); return this.Sleep();}}
    /// <summary>_Is_C_Down</summary><returns></returns>
    public System.Boolean C_Is(){return this.Is(67);}
    /// <summary>if(C_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava C_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.C_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 68 D
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>D_Down</summary><returns></returns>
    public Klava D_Down() { keybd_event(68, 0, 0, 0); return this.Sleep(); }
    /// <summary>D_Up</summary><returns></returns>
    public Klava D_Up() { keybd_event(68, 0, 2, 0); return this.Sleep(); }
    /// <summary>D_Up_Down</summary><returns></returns>
    public Klava D {get{this.D_Down().D_Up(); return this.Sleep();}}
    /// <summary>_Is_D_Down</summary><returns></returns>
    public System.Boolean D_Is(){return this.Is(68);}
    /// <summary>if(D_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava D_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.D_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 69 E
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>E_Down</summary><returns></returns>
    public Klava E_Down() { keybd_event(69, 0, 0, 0); return this.Sleep(); }
    /// <summary>E_Up</summary><returns></returns>
    public Klava E_Up() { keybd_event(69, 0, 2, 0); return this.Sleep(); }
    /// <summary>E_Up_Down</summary><returns></returns>
    public Klava E {get{this.E_Down().E_Up(); return this.Sleep();}}
    /// <summary>_Is_E_Down</summary><returns></returns>
    public System.Boolean E_Is(){return this.Is(69);}
    /// <summary>if(E_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava E_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.E_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 70 F
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>F_Down</summary><returns></returns>
    public Klava F_Down() { keybd_event(70, 0, 0, 0); return this.Sleep(); }
    /// <summary>F_Up</summary><returns></returns>
    public Klava F_Up() { keybd_event(70, 0, 2, 0); return this.Sleep(); }
    /// <summary>F_Up_Down</summary><returns></returns>
    public Klava F {get{this.F_Down().F_Up(); return this.Sleep();}}
    /// <summary>_Is_F_Down</summary><returns></returns>
    public System.Boolean F_Is(){return this.Is(70);}
    /// <summary>if(F_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava F_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.F_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 71 G
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>G_Down</summary><returns></returns>
    public Klava G_Down() { keybd_event(71, 0, 0, 0); return this.Sleep(); }
    /// <summary>G_Up</summary><returns></returns>
    public Klava G_Up() { keybd_event(71, 0, 2, 0); return this.Sleep(); }
    /// <summary>G_Up_Down</summary><returns></returns>
    public Klava G {get{this.G_Down().G_Up(); return this.Sleep();}}
    /// <summary>_Is_G_Down</summary><returns></returns>
    public System.Boolean G_Is(){return this.Is(71);}
    /// <summary>if(G_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava G_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.G_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 72 H
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>H_Down</summary><returns></returns>
    public Klava H_Down() { keybd_event(72, 0, 0, 0); return this.Sleep(); }
    /// <summary>H_Up</summary><returns></returns>
    public Klava H_Up() { keybd_event(72, 0, 2, 0); return this.Sleep(); }
    /// <summary>H_Up_Down</summary><returns></returns>
    public Klava H {get{this.H_Down().H_Up(); return this.Sleep();}}
    /// <summary>_Is_H_Down</summary><returns></returns>
    public System.Boolean H_Is(){return this.Is(72);}
    /// <summary>if(H_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava H_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.H_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 73 I
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>I_Down</summary><returns></returns>
    public Klava I_Down() { keybd_event(73, 0, 0, 0); return this.Sleep(); }
    /// <summary>I_Up</summary><returns></returns>
    public Klava I_Up() { keybd_event(73, 0, 2, 0); return this.Sleep(); }
    /// <summary>I_Up_Down</summary><returns></returns>
    public Klava I {get{this.I_Down().I_Up(); return this.Sleep();}}
    /// <summary>_Is_I_Down</summary><returns></returns>
    public System.Boolean I_Is(){return this.Is(73);}
    /// <summary>if(I_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava I_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.I_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 74 J
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>J_Down</summary><returns></returns>
    public Klava J_Down() { keybd_event(74, 0, 0, 0); return this.Sleep(); }
    /// <summary>J_Up</summary><returns></returns>
    public Klava J_Up() { keybd_event(74, 0, 2, 0); return this.Sleep(); }
    /// <summary>J_Up_Down</summary><returns></returns>
    public Klava J {get{this.J_Down().J_Up(); return this.Sleep();}}
    /// <summary>_Is_J_Down</summary><returns></returns>
    public System.Boolean J_Is(){return this.Is(74);}
    /// <summary>if(J_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava J_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.J_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 75 K
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>K_Down</summary><returns></returns>
    public Klava K_Down() { keybd_event(75, 0, 0, 0); return this.Sleep(); }
    /// <summary>K_Up</summary><returns></returns>
    public Klava K_Up() { keybd_event(75, 0, 2, 0); return this.Sleep(); }
    /// <summary>K_Up_Down</summary><returns></returns>
    public Klava K {get{this.K_Down().K_Up(); return this.Sleep();}}
    /// <summary>_Is_K_Down</summary><returns></returns>
    public System.Boolean K_Is(){return this.Is(75);}
    /// <summary>if(K_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava K_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.K_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 76 L
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>L_Down</summary><returns></returns>
    public Klava L_Down() { keybd_event(76, 0, 0, 0); return this.Sleep(); }
    /// <summary>L_Up</summary><returns></returns>
    public Klava L_Up() { keybd_event(76, 0, 2, 0); return this.Sleep(); }
    /// <summary>L_Up_Down</summary><returns></returns>
    public Klava L {get{this.L_Down().L_Up(); return this.Sleep();}}
    /// <summary>_Is_L_Down</summary><returns></returns>
    public System.Boolean L_Is(){return this.Is(76);}
    /// <summary>if(L_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava L_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.L_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 77 M
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>M_Down</summary><returns></returns>
    public Klava M_Down() { keybd_event(77, 0, 0, 0); return this.Sleep(); }
    /// <summary>M_Up</summary><returns></returns>
    public Klava M_Up() { keybd_event(77, 0, 2, 0); return this.Sleep(); }
    /// <summary>M_Up_Down</summary><returns></returns>
    public Klava M {get{this.M_Down().M_Up(); return this.Sleep();}}
    /// <summary>_Is_M_Down</summary><returns></returns>
    public System.Boolean M_Is(){return this.Is(77);}
    /// <summary>if(M_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava M_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.M_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 78 N
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>N_Down</summary><returns></returns>
    public Klava N_Down() { keybd_event(78, 0, 0, 0); return this.Sleep(); }
    /// <summary>N_Up</summary><returns></returns>
    public Klava N_Up() { keybd_event(78, 0, 2, 0); return this.Sleep(); }
    /// <summary>N_Up_Down</summary><returns></returns>
    public Klava N {get{this.N_Down().N_Up(); return this.Sleep();}}
    /// <summary>_Is_N_Down</summary><returns></returns>
    public System.Boolean N_Is(){return this.Is(78);}
    /// <summary>if(N_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava N_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.N_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 79 O
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>O_Down</summary><returns></returns>
    public Klava O_Down() { keybd_event(79, 0, 0, 0); return this.Sleep(); }
    /// <summary>O_Up</summary><returns></returns>
    public Klava O_Up() { keybd_event(79, 0, 2, 0); return this.Sleep(); }
    /// <summary>O_Up_Down</summary><returns></returns>
    public Klava O {get{this.O_Down().O_Up(); return this.Sleep();}}
    /// <summary>_Is_O_Down</summary><returns></returns>
    public System.Boolean O_Is(){return this.Is(79);}
    /// <summary>if(O_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava O_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.O_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 80 P
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>P_Down</summary><returns></returns>
    public Klava P_Down() { keybd_event(80, 0, 0, 0); return this.Sleep(); }
    /// <summary>P_Up</summary><returns></returns>
    public Klava P_Up() { keybd_event(80, 0, 2, 0); return this.Sleep(); }
    /// <summary>P_Up_Down</summary><returns></returns>
    public Klava P {get{this.P_Down().P_Up(); return this.Sleep();}}
    /// <summary>_Is_P_Down</summary><returns></returns>
    public System.Boolean P_Is(){return this.Is(80);}
    /// <summary>if(P_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava P_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.P_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 81 Q
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Q_Down</summary><returns></returns>
    public Klava Q_Down() { keybd_event(81, 0, 0, 0); return this.Sleep(); }
    /// <summary>Q_Up</summary><returns></returns>
    public Klava Q_Up() { keybd_event(81, 0, 2, 0); return this.Sleep(); }
    /// <summary>Q_Up_Down</summary><returns></returns>
    public Klava Q {get{this.Q_Down().Q_Up(); return this.Sleep();}}
    /// <summary>_Is_Q_Down</summary><returns></returns>
    public System.Boolean Q_Is(){return this.Is(81);}
    /// <summary>if(Q_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Q_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Q_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 82 R
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>R_Down</summary><returns></returns>
    public Klava R_Down() { keybd_event(82, 0, 0, 0); return this.Sleep(); }
    /// <summary>R_Up</summary><returns></returns>
    public Klava R_Up() { keybd_event(82, 0, 2, 0); return this.Sleep(); }
    /// <summary>R_Up_Down</summary><returns></returns>
    public Klava R {get{this.R_Down().R_Up(); return this.Sleep();}}
    /// <summary>_Is_R_Down</summary><returns></returns>
    public System.Boolean R_Is(){return this.Is(82);}
    /// <summary>if(R_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava R_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.R_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 83 S
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>S_Down</summary><returns></returns>
    public Klava S_Down() { keybd_event(83, 0, 0, 0); return this.Sleep(); }
    /// <summary>S_Up</summary><returns></returns>
    public Klava S_Up() { keybd_event(83, 0, 2, 0); return this.Sleep(); }
    /// <summary>S_Up_Down</summary><returns></returns>
    public Klava S {get{this.S_Down().S_Up(); return this.Sleep();}}
    /// <summary>_Is_S_Down</summary><returns></returns>
    public System.Boolean S_Is(){return this.Is(83);}
    /// <summary>if(S_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava S_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.S_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 84 T
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>T_Down</summary><returns></returns>
    public Klava T_Down() { keybd_event(84, 0, 0, 0); return this.Sleep(); }
    /// <summary>T_Up</summary><returns></returns>
    public Klava T_Up() { keybd_event(84, 0, 2, 0); return this.Sleep(); }
    /// <summary>T_Up_Down</summary><returns></returns>
    public Klava T {get{this.T_Down().T_Up(); return this.Sleep();}}
    /// <summary>_Is_T_Down</summary><returns></returns>
    public System.Boolean T_Is(){return this.Is(84);}
    /// <summary>if(T_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava T_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.T_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 85 U
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>U_Down</summary><returns></returns>
    public Klava U_Down() { keybd_event(85, 0, 0, 0); return this.Sleep(); }
    /// <summary>U_Up</summary><returns></returns>
    public Klava U_Up() { keybd_event(85, 0, 2, 0); return this.Sleep(); }
    /// <summary>U_Up_Down</summary><returns></returns>
    public Klava U {get{this.U_Down().U_Up(); return this.Sleep();}}
    /// <summary>_Is_U_Down</summary><returns></returns>
    public System.Boolean U_Is(){return this.Is(85);}
    /// <summary>if(U_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava U_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.U_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 86 V
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>V_Down</summary><returns></returns>
    public Klava V_Down() { keybd_event(86, 0, 0, 0); return this.Sleep(); }
    /// <summary>V_Up</summary><returns></returns>
    public Klava V_Up() { keybd_event(86, 0, 2, 0); return this.Sleep(); }
    /// <summary>V_Up_Down</summary><returns></returns>
    public Klava V {get{this.V_Down().V_Up(); return this.Sleep();}}
    /// <summary>_Is_V_Down</summary><returns></returns>
    public System.Boolean V_Is(){return this.Is(86);}
    /// <summary>if(V_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava V_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.V_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 87 W
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>W_Down</summary><returns></returns>
    public Klava W_Down() { keybd_event(87, 0, 0, 0); return this.Sleep(); }
    /// <summary>W_Up</summary><returns></returns>
    public Klava W_Up() { keybd_event(87, 0, 2, 0); return this.Sleep(); }
    /// <summary>W_Up_Down</summary><returns></returns>
    public Klava W {get{this.W_Down().W_Up(); return this.Sleep();}}
    /// <summary>_Is_W_Down</summary><returns></returns>
    public System.Boolean W_Is(){return this.Is(87);}
    /// <summary>if(W_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava W_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.W_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 88 X
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>X_Down</summary><returns></returns>
    public Klava X_Down() { keybd_event(88, 0, 0, 0); return this.Sleep(); }
    /// <summary>X_Up</summary><returns></returns>
    public Klava X_Up() { keybd_event(88, 0, 2, 0); return this.Sleep(); }
    /// <summary>X_Up_Down</summary><returns></returns>
    public Klava X {get{this.X_Down().X_Up(); return this.Sleep();}}
    /// <summary>_Is_X_Down</summary><returns></returns>
    public System.Boolean X_Is(){return this.Is(88);}
    /// <summary>if(X_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava X_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.X_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 89 Y
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Y_Down</summary><returns></returns>
    public Klava Y_Down() { keybd_event(89, 0, 0, 0); return this.Sleep(); }
    /// <summary>Y_Up</summary><returns></returns>
    public Klava Y_Up() { keybd_event(89, 0, 2, 0); return this.Sleep(); }
    /// <summary>Y_Up_Down</summary><returns></returns>
    public Klava Y {get{this.Y_Down().Y_Up(); return this.Sleep();}}
    /// <summary>_Is_Y_Down</summary><returns></returns>
    public System.Boolean Y_Is(){return this.Is(89);}
    /// <summary>if(Y_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Y_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Y_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 90 Z
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Z_Down</summary><returns></returns>
    public Klava Z_Down() { keybd_event(90, 0, 0, 0); return this.Sleep(); }
    /// <summary>Z_Up</summary><returns></returns>
    public Klava Z_Up() { keybd_event(90, 0, 2, 0); return this.Sleep(); }
    /// <summary>Z_Up_Down</summary><returns></returns>
    public Klava Z {get{this.Z_Down().Z_Up(); return this.Sleep();}}
    /// <summary>_Is_Z_Down</summary><returns></returns>
    public System.Boolean Z_Is(){return this.Is(90);}
    /// <summary>if(Z_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Z_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Z_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 191 Slash
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Slash_Down</summary><returns></returns>
    public Klava Slash_Down() { keybd_event(191, 0, 0, 0); return this.Sleep(); }
    /// <summary>Slash_Up</summary><returns></returns>
    public Klava Slash_Up() { keybd_event(191, 0, 2, 0); return this.Sleep(); }
    /// <summary>Slash_Up_Down</summary><returns></returns>
    public Klava Slash {get{this.Slash_Down().Slash_Up(); return this.Sleep();}}
    /// <summary>_Is_Slash_Down</summary><returns></returns>
    public System.Boolean Slash_Is(){return this.Is(191);}
    /// <summary>if(Slash_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Slash_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Slash_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 32 Space
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Space_Down</summary><returns></returns>
    public Klava Space_Down() { keybd_event(32, 0, 0, 0); return this.Sleep(); }
    /// <summary>Space_Up</summary><returns></returns>
    public Klava Space_Up() { keybd_event(32, 0, 2, 0); return this.Sleep(); }
    /// <summary>Space_Up_Down</summary><returns></returns>
    public Klava Space {get{this.Space_Down().Space_Up(); return this.Sleep();}}
    /// <summary>_Is_Space_Down</summary><returns></returns>
    public System.Boolean Space_Is(){return this.Is(32);}
    /// <summary>if(Space_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Space_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Space_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 48 _0
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_0_Down</summary><returns></returns>
    public Klava _0_Down() { keybd_event(48, 0, 0, 0); return this.Sleep(); }
    /// <summary>_0_Up</summary><returns></returns>
    public Klava _0_Up() { keybd_event(48, 0, 2, 0); return this.Sleep(); }
    /// <summary>_0_Up_Down</summary><returns></returns>
    public Klava _0 {get{this._0_Down()._0_Up(); return this.Sleep();}}
    /// <summary>_Is__0_Down</summary><returns></returns>
    public System.Boolean _0_Is(){return this.Is(48);}
    /// <summary>if(_0_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _0_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._0_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 49 _1
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_1_Down</summary><returns></returns>
    public Klava _1_Down() { keybd_event(49, 0, 0, 0); return this.Sleep(); }
    /// <summary>_1_Up</summary><returns></returns>
    public Klava _1_Up() { keybd_event(49, 0, 2, 0); return this.Sleep(); }
    /// <summary>_1_Up_Down</summary><returns></returns>
    public Klava _1 {get{this._1_Down()._1_Up(); return this.Sleep();}}
    /// <summary>_Is__1_Down</summary><returns></returns>
    public System.Boolean _1_Is(){return this.Is(49);}
    /// <summary>if(_1_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _1_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._1_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 50 _2
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_2_Down</summary><returns></returns>
    public Klava _2_Down() { keybd_event(50, 0, 0, 0); return this.Sleep(); }
    /// <summary>_2_Up</summary><returns></returns>
    public Klava _2_Up() { keybd_event(50, 0, 2, 0); return this.Sleep(); }
    /// <summary>_2_Up_Down</summary><returns></returns>
    public Klava _2 {get{this._2_Down()._2_Up(); return this.Sleep();}}
    /// <summary>_Is__2_Down</summary><returns></returns>
    public System.Boolean _2_Is(){return this.Is(50);}
    /// <summary>if(_2_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _2_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._2_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 51 _3
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_3_Down</summary><returns></returns>
    public Klava _3_Down() { keybd_event(51, 0, 0, 0); return this.Sleep(); }
    /// <summary>_3_Up</summary><returns></returns>
    public Klava _3_Up() { keybd_event(51, 0, 2, 0); return this.Sleep(); }
    /// <summary>_3_Up_Down</summary><returns></returns>
    public Klava _3 {get{this._3_Down()._3_Up(); return this.Sleep();}}
    /// <summary>_Is__3_Down</summary><returns></returns>
    public System.Boolean _3_Is(){return this.Is(51);}
    /// <summary>if(_3_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _3_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._3_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 52 _4
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_4_Down</summary><returns></returns>
    public Klava _4_Down() { keybd_event(52, 0, 0, 0); return this.Sleep(); }
    /// <summary>_4_Up</summary><returns></returns>
    public Klava _4_Up() { keybd_event(52, 0, 2, 0); return this.Sleep(); }
    /// <summary>_4_Up_Down</summary><returns></returns>
    public Klava _4 {get{this._4_Down()._4_Up(); return this.Sleep();}}
    /// <summary>_Is__4_Down</summary><returns></returns>
    public System.Boolean _4_Is(){return this.Is(52);}
    /// <summary>if(_4_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _4_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._4_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 53 _5
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_5_Down</summary><returns></returns>
    public Klava _5_Down() { keybd_event(53, 0, 0, 0); return this.Sleep(); }
    /// <summary>_5_Up</summary><returns></returns>
    public Klava _5_Up() { keybd_event(53, 0, 2, 0); return this.Sleep(); }
    /// <summary>_5_Up_Down</summary><returns></returns>
    public Klava _5 {get{this._5_Down()._5_Up(); return this.Sleep();}}
    /// <summary>_Is__5_Down</summary><returns></returns>
    public System.Boolean _5_Is(){return this.Is(53);}
    /// <summary>if(_5_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _5_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._5_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 54 _6
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_6_Down</summary><returns></returns>
    public Klava _6_Down() { keybd_event(54, 0, 0, 0); return this.Sleep(); }
    /// <summary>_6_Up</summary><returns></returns>
    public Klava _6_Up() { keybd_event(54, 0, 2, 0); return this.Sleep(); }
    /// <summary>_6_Up_Down</summary><returns></returns>
    public Klava _6 {get{this._6_Down()._6_Up(); return this.Sleep();}}
    /// <summary>_Is__6_Down</summary><returns></returns>
    public System.Boolean _6_Is(){return this.Is(54);}
    /// <summary>if(_6_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _6_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._6_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 55 _7
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_7_Down</summary><returns></returns>
    public Klava _7_Down() { keybd_event(55, 0, 0, 0); return this.Sleep(); }
    /// <summary>_7_Up</summary><returns></returns>
    public Klava _7_Up() { keybd_event(55, 0, 2, 0); return this.Sleep(); }
    /// <summary>_7_Up_Down</summary><returns></returns>
    public Klava _7 {get{this._7_Down()._7_Up(); return this.Sleep();}}
    /// <summary>_Is__7_Down</summary><returns></returns>
    public System.Boolean _7_Is(){return this.Is(55);}
    /// <summary>if(_7_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _7_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._7_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 56 _8
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_8_Down</summary><returns></returns>
    public Klava _8_Down() { keybd_event(56, 0, 0, 0); return this.Sleep(); }
    /// <summary>_8_Up</summary><returns></returns>
    public Klava _8_Up() { keybd_event(56, 0, 2, 0); return this.Sleep(); }
    /// <summary>_8_Up_Down</summary><returns></returns>
    public Klava _8 {get{this._8_Down()._8_Up(); return this.Sleep();}}
    /// <summary>_Is__8_Down</summary><returns></returns>
    public System.Boolean _8_Is(){return this.Is(56);}
    /// <summary>if(_8_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _8_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._8_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 57 _9
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>_9_Down</summary><returns></returns>
    public Klava _9_Down() { keybd_event(57, 0, 0, 0); return this.Sleep(); }
    /// <summary>_9_Up</summary><returns></returns>
    public Klava _9_Up() { keybd_event(57, 0, 2, 0); return this.Sleep(); }
    /// <summary>_9_Up_Down</summary><returns></returns>
    public Klava _9 {get{this._9_Down()._9_Up(); return this.Sleep();}}
    /// <summary>_Is__9_Down</summary><returns></returns>
    public System.Boolean _9_Is(){return this.Is(57);}
    /// <summary>if(_9_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava _9_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this._9_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 13 Enter
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Enter_Down</summary><returns></returns>
    public Klava Enter_Down() { keybd_event(13, 0, 0, 0); return this.Sleep(); }
    /// <summary>Enter_Up</summary><returns></returns>
    public Klava Enter_Up() { keybd_event(13, 0, 2, 0); return this.Sleep(); }
    /// <summary>Enter_Up_Down</summary><returns></returns>
    public Klava Enter {get{this.Enter_Down().Enter_Up(); return this.Sleep();}}
    /// <summary>_Is_Enter_Down</summary><returns></returns>
    public System.Boolean Enter_Is(){return this.Is(13);}
    /// <summary>if(Enter_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Enter_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Enter_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 222 Mark
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Mark_Down</summary><returns></returns>
    public Klava Mark_Down() { keybd_event(222, 0, 0, 0); return this.Sleep(); }
    /// <summary>Mark_Up</summary><returns></returns>
    public Klava Mark_Up() { keybd_event(222, 0, 2, 0); return this.Sleep(); }
    /// <summary>Mark_Up_Down</summary><returns></returns>
    public Klava Mark {get{this.Mark_Down().Mark_Up(); return this.Sleep();}}
    /// <summary>_Is_Mark_Down</summary><returns></returns>
    public System.Boolean Mark_Is(){return this.Is(222);}
    /// <summary>if(Mark_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Mark_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Mark_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 16 Shift
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>Shift_Down</summary><returns></returns>
    public Klava Shift_Down() { keybd_event(16, 0, 0, 0); return this.Sleep(); }
    /// <summary>Shift_Up</summary><returns></returns>
    public Klava Shift_Up() { keybd_event(16, 0, 2, 0); return this.Sleep(); }
    /// <summary>Shift_Up_Down</summary><returns></returns>
    public Klava Shift {get{this.Shift_Down().Shift_Up(); return this.Sleep();}}
    /// <summary>_Is_Shift_Down</summary><returns></returns>
    public System.Boolean Shift_Is(){return this.Is(16);}
    /// <summary>if(Shift_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava Shift_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.Shift_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 1 MouseL
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>MouseL_Down</summary><returns></returns>
    public Klava MouseL_Down() { keybd_event(1, 0, 0, 0); return this.Sleep(); }
    /// <summary>MouseL_Up</summary><returns></returns>
    public Klava MouseL_Up() { keybd_event(1, 0, 2, 0); return this.Sleep(); }
    /// <summary>MouseL_Up_Down</summary><returns></returns>
    public Klava MouseL {get{this.MouseL_Down().MouseL_Up(); return this.Sleep();}}
    /// <summary>_Is_MouseL_Down</summary><returns></returns>
    public System.Boolean MouseL_Is(){return this.Is(1);}
    /// <summary>if(MouseL_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava MouseL_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.MouseL_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 2 MouseR
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>MouseR_Down</summary><returns></returns>
    public Klava MouseR_Down() { keybd_event(2, 0, 0, 0); return this.Sleep(); }
    /// <summary>MouseR_Up</summary><returns></returns>
    public Klava MouseR_Up() { keybd_event(2, 0, 2, 0); return this.Sleep(); }
    /// <summary>MouseR_Up_Down</summary><returns></returns>
    public Klava MouseR {get{this.MouseR_Down().MouseR_Up(); return this.Sleep();}}
    /// <summary>_Is_MouseR_Down</summary><returns></returns>
    public System.Boolean MouseR_Is(){return this.Is(2);}
    /// <summary>if(MouseR_Is ){_f1();}else{_f0);}</summary><returns></returns>
    public Klava MouseR_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.MouseR_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
        }
}

