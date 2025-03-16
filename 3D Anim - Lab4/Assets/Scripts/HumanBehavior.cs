using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBehavior : MonoBehaviour
{
    [SerializeField] public Animator humanAnimator;

    private void OnTriggerEnter(Collider other)
    {
        humanAnimator.SetBool("IsSup", true);
    }
}
