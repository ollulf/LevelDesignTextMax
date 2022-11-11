using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineCameraRegister : MonoBehaviour
{
    public bool isDefaultCam = false;
    // Start is called before the first frame update
    void OnEnable()
    {
        CinemachineCamSwitcher.Register(GetComponent<CinemachineVirtualCamera>());
        if (isDefaultCam) CinemachineCamSwitcher.SetDefault(GetComponent<CinemachineVirtualCamera>());
    }

    // Update is called once per frame
    void OnDisable()
    {
        CinemachineCamSwitcher.Unregister(GetComponent<CinemachineVirtualCamera>());
    }
}

