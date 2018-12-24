using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRContlloer : MonoBehaviour {

    public bllet b;

    void Start ()
    {
		
	}


    void Update ()
    {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("トリガーを深く引いた");
            b.Ban();
        }
    }
}
