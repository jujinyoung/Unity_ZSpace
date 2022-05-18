using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coltest : MonoBehaviour
{
    // void OnTriggerEnter(Collider col){
    //     Debug.Log("충돌 감지");
    //     if(col.tag == "animal"){
    //         Destroy(col);
    //     }
    // }

    void OnCollisionEnter(Collision col){
        Debug.Log("충돌 감지");
        if(col.gameObject.tag == "animal"){
            Destroy(col.gameObject);
        }
    }

    

    
}

