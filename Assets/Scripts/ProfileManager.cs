using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    public Text nameText;
    
    public void UpdateName(string newName)
{
    PlayerPrefs.SetString("PlayerName", newName);
    PlayerPrefs.Save();
    LoadPlayerName(); // Memuat ulang nama pemain untuk memperbarui tampilan
}


    void Start()
    {
        // Load nama pemain saat permainan dimulai
        LoadPlayerName();
    }

    void LoadPlayerName()
    {
        // Mengambil nama pemain dari PlayerPrefs
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");

        // Menampilkan nama pemain pada UI
        nameText.text = playerName;
    }
}

