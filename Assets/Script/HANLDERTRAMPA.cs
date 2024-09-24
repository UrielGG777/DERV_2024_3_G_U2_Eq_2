using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HANLDERTRAMPA : MonoBehaviour
{
    float tiempo_enTrigger;
    float tiempo_para_nuevo_enemigo;

    Transform spawn;
    [SerializeField] List <GameObject> lista_enemigos;

    int contador_enemigo_actual;

    void Awake(){
        spawn = GameObject.Find("Spawn Enemigos").transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        tiempo_para_nuevo_enemigo = 1.5f;
        contador_enemigo_actual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other){
        tiempo_enTrigger += Time.deltaTime;
        if (tiempo_enTrigger > tiempo_para_nuevo_enemigo){
            lista_enemigos[contador_enemigo_actual].transform.position = spawn.position;

            lista_enemigos[contador_enemigo_actual].GetComponent<Rigidbody>().AddForce(-1 * 5f * transform.up, ForceMode.Impulse);

            contador_enemigo_actual++;
            contador_enemigo_actual %= contador_enemigo_actual;
        
            tiempo_enTrigger = 0.0f;
        }
    }
}
