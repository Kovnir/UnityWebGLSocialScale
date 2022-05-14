using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Kovnir.WebGLSocialShare
{
    public class WebGLShareExample : MonoBehaviour
    {
        [SerializeField]
        private InputField textInputField;
        [SerializeField]
        private InputField linkInputField;
        [SerializeField]
        private InputField hashtagInputField;
        [SerializeField]
        private Button shareFbButton;
        [SerializeField]
        private Button shareTwitterButton;

        void Start()
        {
            shareFbButton.onClick.AddListener(() =>
            {
                WebGLSocialShare.Facebook(textInputField.text, linkInputField.text);
            });
            shareTwitterButton.onClick.AddListener(() =>
            {
                string hashtags = hashtagInputField.text;
                List<string> hashtagsList = hashtags.Split(' ').ToList();
                WebGLSocialShare.Twitter(textInputField.text, linkInputField.text, hashtagsList);
            });
        }
    }
}