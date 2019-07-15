using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
