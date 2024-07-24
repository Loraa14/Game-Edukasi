using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField nameInputField;

    public void SavePlayerName()
    {
        string playerName = nameInputField.text;

        // Menyimpan nama pemain ke PlayerPrefs
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        Debug.Log("Nama pemain telah disimpan: " + playerName);
    }
}

