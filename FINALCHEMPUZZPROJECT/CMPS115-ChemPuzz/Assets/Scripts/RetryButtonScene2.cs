using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
//Unity documentation for LoadLevel: https://docs.unity3d.com/ScriptReference/Application.LoadLevel.html
public class RetryButtonScene2 : MonoBehaviour
{
    public void ToGame() => Application.LoadLevel("ChemPuzzScenev2Level2");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
