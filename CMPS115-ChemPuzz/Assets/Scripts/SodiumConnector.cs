using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
//Unity Documentation for Instantiate: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
//Unity Documentation for On Collision: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html
//Unity Documentation for Set Active: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
public class SodiumConnector : MonoBehaviour
{
    public GameObject Na20_inbetween;
    public GameObject Na20_molecule;

    public Transform MoleculeSpawner;
    public bool flag;
    
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        
    }
    void OnCollisionEnter2D(Collision2D c){
        if(c.gameObject.tag == "Chlorine"){
            c.gameObject.SetActive(false);
        }
        if(c.gameObject.tag == "Oxygen"){
            flag = true;
            Instantiate(Na20_inbetween, MoleculeSpawner.position, Quaternion.identity);
            c.gameObject.SetActive(false);
           
        }
         if(c.gameObject.tag == "Na2O_inbetween"){
            flag = true;
            Instantiate(Na20_molecule, MoleculeSpawner.position, Quaternion.identity);
            c.gameObject.SetActive(false);
           
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
