using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAnimation : MonoBehaviour
{
    private Animator _anim;
    private Animator _anim2;

    // Start is called before the first frame update
    void Start () {
        //assign handle to animator
        _anim = GetComponentInChildren<Animator> ();
        _anim2= transform.GetChild(1).GetComponent<Animator>();
    }

    public void Touch()
    {
        _anim.SetTrigger("Touch");
    }

    public void Touchagain()
    {
        _anim2.SetTrigger("Touchagain");
    }
}
