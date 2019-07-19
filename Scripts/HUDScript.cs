using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This script implements the Heads Up Display for Scientific Molecule Names
//Sources Cited:
//Unity Documentation for FindGameObjectwithTag: https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
public class HUDScript : MonoBehaviour
{
    public Text NaCl_moleculeChecker;
    public static bool MDScript;
    // Start is called before the first frame update
    private string status;
    public static int atoms;
    private string line;
    private string title;
    void Start()
    {
        atoms = 0;
        line = "\n";
        status = "";
        title = "Molecules to Create: ";
        //Molecules
        string H2O = "water";
        string NaCl = "Sodium Chloride";
        string CCl4 = "Tetrachloromethane";
        string CH4 = "Methane";
        string Na2O = "Disodium Oxide";
        if(GameObject.FindGameObjectWithTag ("H2O_molecule")){
            status = status+H2O+line;
        }
        if(GameObject.FindGameObjectWithTag ("NaCl_molecule")){
            status = status+NaCl+line;
        }
        if(GameObject.FindGameObjectWithTag ("CCl4_molecule")){
            status = status+CCl4+line;
        }
        if(GameObject.FindGameObjectWithTag ("CH4_molecule")){
            status = status+CH4+line;
        }
        if(GameObject.FindGameObjectWithTag ("Na2O_molecule")){
            status = status+Na2O+line;
        }
        NaCl_moleculeChecker.text = title + line + status + line; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag ("Carbon")){
            atoms = atoms + CarbonConnector.atoms;
        }
        if(GameObject.FindGameObjectWithTag ("Player")){
            atoms = atoms + HydrogenConnector.atoms;
        }
        if(GameObject.FindGameObjectWithTag ("Player")){
            atoms = atoms + OxygenConnector.atoms;
        }
        if(GameObject.FindGameObjectWithTag ("Player")){
            atoms = atoms + ChlorineConnector.atoms;
        }
        if(GameObject.FindGameObjectWithTag ("Player")){
            atoms = atoms + SodiumConnector.atoms;
        }
        MDScript = molecule_destroyer.NaClbool;
      /*   if( status == "0/1" && MDScript == true){
            status = "1/1";
            NaCl_moleculeChecker.text = "SodiumChloride: " + status;
      }*/
    }
}
