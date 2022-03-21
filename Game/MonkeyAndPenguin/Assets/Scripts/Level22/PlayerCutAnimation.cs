using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCutAnimation : MonoBehaviour
{
 //handle to animator
    private Animator _anim;

    // Start is called before the first frame update
    void Start () {
        //assign handle to animator
        _anim = GetComponentInChildren<Animator> ();
    }

    public void Happy()
    {
        _anim.SetTrigger("Happy");
    }
}
