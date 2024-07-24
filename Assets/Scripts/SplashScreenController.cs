using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour
{
    public string nextSceneName; // Nama scene berikutnya setelah splash screen
    public float splashScreenDuration = 2f; // Durasi splash screen dalam detik

    private void Start()
    {
        Invoke("LoadNextScene", splashScreenDuration);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
