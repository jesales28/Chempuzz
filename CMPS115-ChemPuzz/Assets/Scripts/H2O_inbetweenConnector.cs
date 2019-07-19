using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
//Unity Documentation https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
//Unity Documentation for Instantiate: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
//Unity Documentation for On Collision: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html
//Unity Documentation for Set Active: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
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
