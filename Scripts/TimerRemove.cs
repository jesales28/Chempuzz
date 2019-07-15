using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerRemove : MonoBehaviour
{
    public GameObject molecule;
    // Start is called before the first frame update
    public GameObject atom;
    public bool timerBool;
    void Start()
    {
        timerBool = false;
    }
    public IEnumerator Timer(){
        while(timerBool == true){
            yield return new WaitForSeconds(1);
            molecule.gameObject.SetActive(false);
        }
        timerBool = false;
    }
   /*  void OnCollisionEnter2D(Collision2D c){
         if(c.gameObject.tag == "Chlorine"){
            StartCoroutine(Timer());
        }
   }*/

    // Update is called once per frame
    void Update()
    {
        ChlorineConnector chlorineAtomScript = atom.GetComponent<ChlorineConnector>();
        if(chlorineAtomScript.flag == true){
            timerBool = true;
            StartCoroutine(Timer());
        }


    }
}
