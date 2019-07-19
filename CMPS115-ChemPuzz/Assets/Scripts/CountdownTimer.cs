using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0;
    public float startingTime = 10;
    int time = 0;
    private string description = "Time: ";

   /*  [serializeField]*/ public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1* Time.deltaTime;
        time = (int)currentTime;
        countdownText.text = description + time.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
