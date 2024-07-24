using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public InputField nameInputField;
    public ProfileManager profileManager;

    public void OnSaveButtonClick()
    {
        string newName = nameInputField.text;
        profileManager.UpdateName(newName);
    }
}

