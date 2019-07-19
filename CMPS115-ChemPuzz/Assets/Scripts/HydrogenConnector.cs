using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
//Unity Documentation for Instantiate: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
//Unity Documentation for On Collision: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html
//Unity Documentation for Set Active: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
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
    public static int atoms;
    void Start()
    {
        flag = false;
        atoms = 1;
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
