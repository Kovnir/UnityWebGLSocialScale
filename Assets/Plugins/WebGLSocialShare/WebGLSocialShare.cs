using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Kovnir.WebGLSocialShare
{
    public static class WebGLSocialShare
    {
        [DllImport("__Internal")]
        private static extern void ShareFB(string text, string link);
        
        [DllImport("__Internal")]
        private static extern void ShareTwitter(string text, string link, string hashtags);

        public static void Facebook(string text, string link)
        {
            Share("FB", text, () =>
            {
                ShareFB(text, link);
            });
        }
        
        public static void Twitter(string text, string link, List<string> hashtags = null)
        {
            string hashtagsParam = "";
            if (hashtags != null)
            {
                for (var i = 0; i < hashtags.Count; i++)
                {
                    string hashtag = hashtags[i];
                    if (i == 0)
                    {
                        //first one should be without #
                        if (hashtag[0] == '#')
                        {
                            hashtag.Remove('#');
                        }
                    }
                    else
                    {
                        if (hashtag[0] != '#')
                        {
                            hashtag = "#" + hashtag;
                        }
                    }
                    hashtags[i] = hashtag;
                }
                foreach (string hashtag in hashtags)
                {
                    hashtagsParam += hashtag + " ";
                }
            }

            Share("Twitter", text, () =>
            {
                ShareTwitter(text, link, hashtagsParam);
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