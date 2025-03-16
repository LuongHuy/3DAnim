using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] public Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("IsOpen", true);
        doorAnimator.SetBool("IsClose", false);
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("IsClose", true);
        doorAnimator.SetBool("IsOpen", false);
    }
}
