using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenConnector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject O2_molecule;
    public GameObject CO2_inbetween;
    public GameObject CO2_molecule;
    public Transform MoleculeSpawner;
    public bool flag;
    void Start()
    {
        flag = false;
    }

    void OnCollisionEnter2D(Collision2D c){
        if(c.gameObject.tag == "Oxygen"){
            flag = true;
            Instantiate(O2_molecule, MoleculeSpawner.position, Quaternion.identity);
            c.gameObject.SetActive(false);
           
        }

        if(c.gameObject.tag == "Hydrogen"){
            flag = true;
            
            c.gameObject.SetActive(false);
           
        }
        if(c.gameObject.tag == "Carbon"){
            flag = true;
            Instantiate(CO2_inbetween, MoleculeSpawner.position, Quaternion.identity);
            c.gameObject.SetActive(false);
           
        }
        if(c.gameObject.tag == "CO2_inbetween"){
            flag = true;
            Instantiate(CO2_molecule, MoleculeSpawner.position, Quaternion.identity);
            c.gameObject.SetActive(false);
           
        }
        if(c.gameObject.tag == "Sodium"){
            c.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
