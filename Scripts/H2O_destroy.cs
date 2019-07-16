using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
// Unity Documentation for wait for seconds: https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
// Unity Documentation for Awake(): https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html
public class H2O_destroy : MonoBehaviour
{
    public GameObject molecule;
    public GameObject atom2;
    public bool timerBool;
    // Start is called before the first frame update
     public IEnumerator Timer(){
        while(timerBool == true){
            yield return new WaitForSeconds(2);
            molecule.gameObject.SetActive(false);
        }
        timerBool = false;
    }
    void Start()
    {
        timerBool = true;
    }

    // Update is called once per frame
    void Update()
    {
     //   while(timerBool == true){
      //  }
    }
    void Awake(){
        StartCoroutine(Timer());
    }
}
