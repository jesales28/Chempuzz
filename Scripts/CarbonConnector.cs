using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarbonConnector : MonoBehaviour
{
    public GameObject C2_molecule;
    public Transform MoleculeSpawner;
    public bool flag;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }
    void OnCollisionEnter2D(Collision2D c){
        if(c.gameObject.tag == "Oxygen"){
            c.gameObject.SetActive(false);
        }
        if(c.gameObject.tag == "Hydrogen"){
            c.gameObject.SetActive(false);
        }
        if(c.gameObject.tag == "Chlorine"){
            c.gameObject.SetActive(false);
        }
         if(c.gameObject.tag == "Carbon"){
            flag = true;
            Instantiate(C2_molecule, MoleculeSpawner.position, Quaternion.identity);
            c.gameObject.SetActive(false);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
