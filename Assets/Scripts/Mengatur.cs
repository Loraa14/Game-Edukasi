using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mengatur : MonoBehaviour
{
    [Header("Descripsi Rumah Adat")]
    public TrackableAr[] tr;
    public string[] nama;
    [TextArea]
    public string[] descripsi;

    [Header("UI Descripsi")]
    public Text txtNama;
    public Text txtDescripsi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i < tr.Length; i++)
        {
            if (tr[i].GetMarker())
            {
               //
            }
        }
    }
}