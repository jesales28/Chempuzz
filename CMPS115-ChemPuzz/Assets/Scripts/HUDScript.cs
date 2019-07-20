using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This script implements the Heads Up Display for Scientific Molecule Names
//Sources Cited:
//Unity Documentation for FindGameObjectwithTag: https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
//String Regex Stack Overflow for getting rid of last comma: https://stackoverflow.com/questions/49006348/how-to-replace-last-comma-with-and

public class HUDScript : MonoBehaviour
{
    public Text NaCl_moleculeChecker;
    public Text atomCount;
    public static bool MDScript;
    // Start is called before the first frame update
    private string status;
    public static int atoms;
    private string comma;
    private string title;
    private GameObject Panel;
    public static bool atomCheck;


    void Start()
    {
        Panel = GameObject.FindGameObjectWithTag("Panel");
        Panel.gameObject.SetActive(false);
        atomCheck = false;
        atoms = 0;
        comma = ", ";
        status = "";
        title = "Molecules to Create: ";
        //Molecules
        string H2O = "water";
        string NaCl = "Sodium Chloride";
        string CCl4 = "Tetrachloromethane";
        string CH4 = "Methane";
        string Na2O = "Disodium Oxide";
        if(GameObject.FindGameObjectWithTag ("H2O_molecule")){
            status = status+H2O+comma;
        }
        if(GameObject.FindGameObjectWithTag ("NaCl_molecule")){
            status = status+NaCl+comma;
        }
        if(GameObject.FindGameObjectWithTag ("CCl4_molecule")){
            status = status+CCl4+comma;
        }
        if(GameObject.FindGameObjectWithTag ("CH4_molecule")){
            status = status+CH4+comma;
        }
        if(GameObject.FindGameObjectWithTag ("Na2O_molecule")){
            status = status+Na2O+comma;
        }
        if(status.LastIndexOf(',') < status.Length-1){
            status = status.Substring(0, status.LastIndexOf(',')) + ""
            + status.Substring(status.LastIndexOf(',')+1);
        }
        NaCl_moleculeChecker.text = title + status; 

        //for each atom the game will count up by 1 to get the total number of atoms on screen
        if(GameObject.Find("CarbonAtom")){
            atoms = atoms + GameObject.FindGameObjectsWithTag("Carbon").Length;
        }
        if(GameObject.Find("HydrogenAtom")){ 
            
            atoms = atoms + GameObject.FindGameObjectsWithTag("Hydrogen").Length;
        }
        if(GameObject.Find("OxygenAtom")){
            atoms = atoms + GameObject.FindGameObjectsWithTag("Oxygen").Length;
        }
        if(GameObject.Find("ChlorineAtom")){
            atoms = atoms + GameObject.FindGameObjectsWithTag("Chlorine").Length;
        }
        if(GameObject.Find("SodiumAtom")){
            atoms = atoms + GameObject.FindGameObjectsWithTag("Sodium").Length;
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        atomCount.text = atoms.ToString();
        //then for each molecule created when the instantiate function creates the clone
        //subtract from the variable atoms the amount of atoms it would take to create the molecule

        


        //if atoms value is zero then go to next level.
        if(atoms == 0 && atomCheck == true){
            Panel.gameObject.SetActive(true);
        }

        MDScript = molecule_destroyer.NaClbool;
      /*   if( status == "0/1" && MDScript == true){
            status = "1/1";
            NaCl_moleculeChecker.text = "SodiumChloride: " + status;
      }*/
    }
}
