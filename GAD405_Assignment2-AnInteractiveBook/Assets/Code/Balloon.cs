using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public Animator myAnimator;

    public void launch()
    {
        myAnimator.SetTrigger("launch");
    }
}
