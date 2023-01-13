using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cadreManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Material[] materials;
    [SerializeField]private MeshRenderer meshCadre;
    [SerializeField] private GameObject cadreInterne;

    public int collisions;
    void Start()
    {
        meshCadre = cadreInterne.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("desoperculateur") && collisions<3){
            collisions++;
            meshCadre.material = materials[collisions];
        }
    }
}
