using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void OpenNativeCamera(int front);
#endif

    public RawImage previewImage;

    public void OpenBackCamera()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        OpenNativeCamera(0);
#endif
    }

    public void OnImageReceived(string base64)
    {
        string clean = base64.Substring(base64.IndexOf(",") + 1);

        byte[] imageBytes = Convert.FromBase64String(clean);

        Texture2D tex = new Texture2D(2, 2);

        tex.LoadImage(imageBytes);

        previewImage.texture = tex;

        Debug.Log("Photo loaded.");
    }
}