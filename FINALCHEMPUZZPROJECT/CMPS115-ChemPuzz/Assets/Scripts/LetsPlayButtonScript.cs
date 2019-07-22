using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetsPlayButtonScript : MonoBehaviour
{
    public Button LetsPlayButton;
    // Start is called before the first frame update
    void Start()
    {
        LetsPlayButton.onClick.AddListener(() => { Camera.main.transform.Rotate(new Vector​3(0.0f, 90.0f, 0.0f));;});
      //  Button btn = LetsPlayButton.GetComponent<Button>();
      //  btn.onClick.AddListener<TaskOnClick>;
    }
    
   /*  void TaskonClick(){
        int speed = 1;
        Camera.main.transform.eulerAngles = Vector3.Lerp(Camera.main.transform.eulerAngles,
        new Vector3(0,90,0), Time.deltaTime*speed);
        Debug.Log("A button was pressed");
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
