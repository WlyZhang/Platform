using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

public class IOSInterface : AbstractClass {

    [DllImport("__Internal")]
    private static extern void _OpenUserList(string textureName);//打开在线人数

    
    public override void OpenUserList(string show)
    {
        Debug.Log("OpenUserList +    unity3D");
        _OpenUserList(show);
    }
}
