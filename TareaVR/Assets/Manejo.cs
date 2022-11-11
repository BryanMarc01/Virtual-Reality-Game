using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class Manejo : MonoBehaviour
{
    // Start is called before the first frame update
  void Start()
    {
        
    if (!XRSettings.isDeviceActive){
    Debug.Log("No Headset conectado");
    }
    else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" 
    || XRSettings.loadedDeviceName == "MockHMDDisplay"))
    {
    Debug.Log("Usando Mock HMD");    
    }

else
{
    Debug.Log("Tenemos un headset" + XRSettings.loadedDeviceName);
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
