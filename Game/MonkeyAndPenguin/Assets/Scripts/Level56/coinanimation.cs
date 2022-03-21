using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinanimation : MonoBehaviour
{
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator> ();
    }

    public void Coin(bool coins)
    {
        _anim.SetBool("coin",coins);
    }
}
