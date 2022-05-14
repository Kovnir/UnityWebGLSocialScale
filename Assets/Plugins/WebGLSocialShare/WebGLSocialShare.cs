using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Kovnir.WebGLSocialShare
{
    public static class WebGLSocialShare
    {
        [DllImport("__Internal")]
        private static extern void ShareFB(string str);
        
        [DllImport("__Internal")]
        private static extern void ShareTwitter(string str);

        public static void Facebook(string text)
        {
            Share("FB", text, ShareFB);
        }
        
        public static void Twitter(string text)
        {
            Share("Twitter", text, ShareTwitter);
        }
        
        private static void Share(string media, string text, Action<string> action)
        {
            if (Application.isEditor)
            {
                Debug.Log($"{media} Share: {text}");
            }
            else
            {
                switch (Application.platform)
                {
                    case RuntimePlatform.WebGLPlayer:
                        action(text);
                        break;
                    default:
                        Debug.LogError("WebGLSharing is not supported for " + Application.platform);
                        break;
                }
            }
        }
    }
}