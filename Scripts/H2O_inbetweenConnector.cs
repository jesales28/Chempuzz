using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2O_inbetweenConnector : MonoBehaviour
{
    public GameObject H2O_molecule;
    public Transform MoleculeSpawner;
    public bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    void OnCollisionEnter2D(Collision2D collide)
    {
        if(collide.gameObject.tag == "Hydrogen"){
            flag = true;
            Instantiate(H2O_molecule, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
