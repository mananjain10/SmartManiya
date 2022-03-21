using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level22Animation : MonoBehaviour
{
    private Animator _anim;
    private Animator _anim2;

    // Start is called before the first frame update
    void Start () {
        //assign handle to animator
        _anim = GetComponentInChildren<Animator> ();
        _anim2= transform.GetChild(1).GetComponent<Animator>();
    }

    public void TouchCutCoin()
    {
        _anim.SetTrigger("TouchCutCoin");
    }

    public void DoorVisible()
    {
        _anim2.SetTrigger("Doorvis");
    }
}
