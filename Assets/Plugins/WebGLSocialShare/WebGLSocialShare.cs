using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Kovnir.WebGLSocialShare
{
    public static class WebGLSocialShare
    {
        [DllImport("__Internal")]
        private static extern void ShareFB(string text, string link, string hashtags, string image);
        
        [DllImport("__Internal")]
        private static extern void ShareTwitter(string text, string link, string hashtags);

        public static void Facebook(string text, string link, string hashtags = "", string image = "")
        {
            Share("FB", text, () =>
            {
                ShareFB(text, link, hashtags, image);
            });
        }
        
        public static void Twitter(string text, string link, string hashtags = "")
        {
            Share("Twitter", text, () =>
            {
                ShareTwitter(text, link, hashtags);
            });
        }
        
        private static void Share(string media, string text, Action action)
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
                        action();
                        break;
                    default:
                        Debug.LogError("WebGLSharing is not supported for " + Application.platform);
                        break;
                }
            }
        }
    }
}