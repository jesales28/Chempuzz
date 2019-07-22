using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Sources Cited:
// Unity Documentation for wait for seconds: https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
// Unity Documentation for Awake(): https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html
public class molecule_destroyer : MonoBehaviour
{
    public GameObject molecule;
    public bool timerBool;
    public static bool NaClbool;
    // Start is called before the first frame update
     public IEnumerator Timer(){
        while(timerBool == true){
            yield return new WaitForSeconds(2);
            NaClbool = true;
            if(molecule.tag == "NaCl_molecule" || molecule.tag == "HCl_molecule")
            {
                //for all the two atom molecules subtract 2 from the atom count
                HUDScript.atoms = HUDScript.atoms - 2;
            }
            if(molecule.tag == "O2_molecule"|| molecule.tag == "C2_molecule"){

                //since the bug for O2 and C2 has it subtracting twice per molecule
                //have it subtract 1 instead to get the correct amount of 2 atoms subtracted
                HUDScript.atoms = HUDScript.atoms - 1;
            }
            if( molecule.tag == "H2O_molecule" || molecule.tag == "Na2O_molecule" || molecule.tag == "CO2_molecule")
            {
                //for all the three atom molecules subtract 3 from the atom count
                HUDScript.atoms = HUDScript.atoms - 3;
            }
            if(molecule.tag == "CCl4_molecule" || molecule.tag == "CH4_molecule")
            {
                //for all the five atom molecules subtract 5 from the atom count
                HUDScript.atoms = HUDScript.atoms - 5;
            }
            if(HUDScript.atoms == 0 )
            {
                HUDScript.atomCheck = true;
            }
            molecule.gameObject.SetActive(false);
        }
        timerBool = false;
    }
    void Start()
    {
        timerBool = true;
        NaClbool = false;
    }

    // Update is called once per frame
    void Update()
    {
     //   while(timerBool == true){
      //  }
    }
    //When Script is activated, start timer coroutine.
    void Awake(){
        StartCoroutine(Timer());
    }
}
