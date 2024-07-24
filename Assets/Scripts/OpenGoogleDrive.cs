using UnityEngine;
using UnityEngine.UI;

public class OpenGoogleDrive : MonoBehaviour
{
    public string googleDriveURL; // URL Google Drive yang ingin Anda buka

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OpenURL);
    }

    private void OpenURL()
    {
        Application.OpenURL(googleDriveURL);
    }
}
