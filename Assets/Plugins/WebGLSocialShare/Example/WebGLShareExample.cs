using UnityEngine;
using UnityEngine.UI;

namespace Kovnir.WebGLSocialShare
{
    public class WebGLShareExample : MonoBehaviour
    {
        [SerializeField]
        private InputField inputField;
        [SerializeField]
        private Button shareFbButton;
        [SerializeField]
        private Button shareTwitterButton;

        // Start is called before the first frame update
        void Start()
        {
            shareFbButton.onClick.AddListener(() =>
            {
                WebGLSocialShare.Facebook(inputField.text);
            });
            shareTwitterButton.onClick.AddListener(() =>
            {
                WebGLSocialShare.Twitter(inputField.text);
            });
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}