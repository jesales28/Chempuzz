using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Some code to make object rotate
//From UFO tutorial video at: https://www.youtube.com/watch?v=BpgG7nBQxFc
//Unity Documentation for rotate: https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (0,0,45)*Time.deltaTime);
    }
}
