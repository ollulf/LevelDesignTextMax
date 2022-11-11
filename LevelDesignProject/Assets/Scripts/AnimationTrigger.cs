using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;

    public bool useCustomCamera;
    public CinemachineVirtualCamera myVirtualCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("triggered", true);

            if (useCustomCamera)
            {
                if (CinemachineCamSwitcher.activeCamera != myVirtualCamera) CinemachineCamSwitcher.SwitchCamera(myVirtualCamera);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (useCustomCamera)
            {
                CinemachineCamSwitcher.SwitchCamera(CinemachineCamSwitcher.defaultCamera);
            }
        }
    }

}
