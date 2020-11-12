using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VerificaTarget : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    public GameObject card;

    void Start()
    {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {

        }
        else
        {
            transform.position=new Vector3(0,0,0);
        }
    }	
}