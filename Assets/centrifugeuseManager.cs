using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centrifugeuseManager : MonoBehaviour
{
    // Start is called before the first frame update
    int collid;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("cadreMiel") && other.gameObject.GetComponent<cadreManager>().collisions ==2){
            collid++;

            if(collid>=3){

                gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;

            }

        }
    }
}
