using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetects : MonoBehaviour
{
   private void OnCollisionEnter(Collision other){
    Debug.Log("E.Enter" + other.gameObject.name);
   }
   private void OnCollisionStay(Collision other){
    Debug.Log("E.Stay" + other.gameObject.name);
    }
    private void OnCollisionExit(Collision other){
    Debug.Log("E.Exit" + other.gameObject.name);
    }
}
