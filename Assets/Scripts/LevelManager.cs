using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //start is callad before the first frame update
    public void LoadToScane(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}