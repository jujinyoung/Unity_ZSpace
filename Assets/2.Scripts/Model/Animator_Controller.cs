using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator_Controller : MonoBehaviour
{
    Rigidbody rigid;
    Animator anim;
    private void Start() {
        rigid = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update() {
        if(rigid.isKinematic){
            anim.enabled = false;
        }else
        {
            anim.enabled = true;
        }
    }
}
