using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdwonTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 35f;

    [SerializeField] Text CountDownText;

    public GameObject popups;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        popups.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountDownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
             popups.SetActive(true); 
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("CountDown");
    }
}