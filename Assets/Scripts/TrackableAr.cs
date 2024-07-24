using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackableAr : DefaultTrackableEventHandler
{
    private bool marker;
    public AudioSource suara;

    void Awake()
    {
        suara = GetComponent<AudioSource>();
    }
    protected override void OnTrackingFound()
    {
        marker = true;
        base.OnTrackingFound();
        suara.Play();
    }

    protected override void OnTrackingLost()
    {
        marker = false ;    
        base.OnTrackingLost();
        suara.Stop();
    }

    public bool GetMarker()
    {
        return marker;
    }

}