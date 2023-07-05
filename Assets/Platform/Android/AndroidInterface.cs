#if UNITY_ANDROID
using UnityEngine;
using System.Collections;
using System;

public class AndroidInterface : AbstractClass
{
    public override void OpenUserList(string show)
    {
        Debug.Log("OpenUserList");
        MyAndroidPlayer.SendMessage("OpenUserList", show);
    }
}
#endif