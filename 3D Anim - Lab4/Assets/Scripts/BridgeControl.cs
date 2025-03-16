using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    [SerializeField] public Animator bridgeAnimator;

    private void OnTriggerEnter(Collider other)
    {
        bridgeAnimator.SetBool("IsIn", true);
        bridgeAnimator.SetBool("IsOut", false);
    }

    private void OnTriggerExit(Collider other)
    {
            bridgeAnimator.SetBool("IsOut", true);
            bridgeAnimator.SetBool("IsIn", false);
    }
}
