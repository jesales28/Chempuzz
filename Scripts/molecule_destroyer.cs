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
    public GameObject atom2;
    public bool timerBool;
    public static bool NaClbool;
    // Start is called before the first frame update
     public IEnumerator Timer(){
        while(timerBool == true){
            yield return new WaitForSeconds(2);
            NaClbool = true;
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
