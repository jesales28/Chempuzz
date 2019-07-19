using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
//Unity Documentation for Instantiate: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
//Unity Documentation for On Collision: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html
//Unity Documentation for Set Active: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
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
    public static int atoms;
    void Start()
    {
        flag = false;
        atoms = 1;
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
