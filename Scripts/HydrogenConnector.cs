using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrogenConnector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject OH;
    public GameObject H2O_molecule;
    public GameObject CH4_inbetween1;
    public GameObject CH4_inbetween2;
    public GameObject CH4_inbetween3;
    public GameObject CH4_molecule;
    public Transform MoleculeSpawner;
    public bool flag;
    void Start()
    {
        flag = false;
    }

    void OnCollisionEnter2D(Collision2D collide){
        if(collide.gameObject.tag == "Oxygen"){
            flag = true;
            Instantiate(OH, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "OH"){
            flag = true;
            
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "Carbon"){
            flag = true;
            Instantiate(CH4_inbetween1, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "CH4_inbetween1"){
            flag = true;
            Instantiate(CH4_inbetween2, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "CH4_inbetween2"){
            flag = true;
            Instantiate(CH4_inbetween3, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "CH4_inbetween3"){
            flag = true;
            Instantiate(CH4_molecule, MoleculeSpawner.position, Quaternion.identity);
            collide.gameObject.SetActive(false);
           
        }
        if(collide.gameObject.tag == "Chlorine"){
            collide.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
