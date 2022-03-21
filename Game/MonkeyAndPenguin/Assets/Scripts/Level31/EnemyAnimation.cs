using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAnimation : MonoBehaviour
{
    private Animator _anim2;
    void Start () {
        //assign handle to animator
        _anim2= transform.GetChild(0).GetComponent<Animator>();
    }
    public void DoorVisible()
    {
        _anim2.SetTrigger("AngryDoorVis");
    }

}