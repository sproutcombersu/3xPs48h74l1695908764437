using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OneSignalSDK;

public class EAOnesignalModul : MonoBehaviour
{
        private string ONESIGNAL_ID = "cefb1d90-b4f8-4a23-ac8d-987caa93089f";
    // Start is called before the first frame update
    void Start()
    {
        OneSignal.Default.Initialize(ONESIGNAL_ID);
    }

}
