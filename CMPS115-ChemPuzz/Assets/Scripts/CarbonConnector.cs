using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
//Unity Documentation for Instantiate: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
//Unity Documentation for On Collision: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html
//Unity Documentation for Set Active: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
public class CarbonConnector : MonoBehaviour
{
    public GameObject C2_molecule;
    public Transform MoleculeSpawner;
    public bool flag;
    public static int atoms;

    // Start is called before the first frame update
    void Start()
    {
        atoms = 1;

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
