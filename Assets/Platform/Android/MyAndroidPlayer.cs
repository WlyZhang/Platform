#if UNITY_ANDROID
using UnityEngine;
using System.Collections;

public class MyAndroidPlayer : MonoBehaviour
{
    public delegate void ObtainMessageDelegate(string messageType, string message);
    public static ObtainMessageDelegate ObtainMessage;

    private static AndroidJavaClass androidJavaClass;

    private static AndroidJavaObject androidJavaObject;

    private char SEPARATOR = '~';

    void Awake()
    {
        Debug.Log("222");
        if (Application.platform != RuntimePlatform.Android) return;
        androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
        androidJavaObject = androidJavaObject.Get<AndroidJavaObject>("functionUnity");
        Debug.Log("333");
    }

    public static void SendMessage(string method, string msgArgs)
    {
        Debug.Log(method);
        androidJavaObject.Call(method, new string[] { msgArgs });
    }
}
#endif