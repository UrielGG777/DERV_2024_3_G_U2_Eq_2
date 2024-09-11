using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Texto_cont;
    int contador;

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if(obj.CompareTag("TypeEnemy2"))
        {
            Destroy(obj);
            contador ++;
            Texto_cont.text = "Quedan:" + contador;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
