using UnityEngine;
using UnityEngine.UI;

namespace Kovnir.WebGLSocialShare
{
    public class WebGLShareExample : MonoBehaviour
    {
        [SerializeField]
        private InputField textInputField;
        [SerializeField]
        private InputField imageInputField;
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
                WebGLSocialShare.Facebook(textInputField.text, linkInputField.text, hashtagInputField.text, imageInputField.text);
            });
            shareTwitterButton.onClick.AddListener(() =>
            {
                WebGLSocialShare.Twitter(textInputField.text, linkInputField.text, hashtagInputField.text);
            });
        }
    }
}