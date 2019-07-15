using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChlorineConnector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NaCl_molecule;
    public GameObject HCl_molecule;
    public GameObject CCl4_inbetween1;
    public GameObject CCl4_inbetween2;
    public GameObject CCl4_inbetween3;
    public GameObject CCl4_molecule;
    public Transform MoleculeSpawner;
    public bool flag;
    void Start()
    {
        flag = false;
    }

    void OnCollisionEnter2D(Collision2D collide){
        if(collide.gameObject.tag == "Sodium"){
            flag = true;
            Instantiate(NaCl_molecule, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "Hydrogen"){
            flag = true;
            Instantiate(HCl_molecule, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "Carbon"){
            flag = true;
            Instantiate(CCl4_inbetween1, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
         if(collide.gameObject.tag == "CCl4_inbetween1"){
            flag = true;
            Instantiate(CCl4_inbetween2, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "CCl4_inbetween2"){
            flag = true;
            Instantiate(CCl4_inbetween3, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "CCl4_inbetween3"){
            flag = true;
            Instantiate(CCl4_molecule, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
