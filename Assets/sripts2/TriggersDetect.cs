using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersDetect : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other){
        Debug.Log("T.Enter--" + other.gameObject.name);
   }
   private void OnTriggerStay(Collider other){
        Debug.Log("T.Stay" + other.gameObject.name);
   }
   private void OnTriggerExit(Collider other){
        Debug.Log("T.Exit" + other.gameObject.name);
   }
}
