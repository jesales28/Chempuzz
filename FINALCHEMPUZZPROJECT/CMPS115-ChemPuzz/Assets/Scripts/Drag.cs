using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sources Cited:
//Unity Documentation for World Point: https://docs.unity3d.com/ScriptReference/Camera.ScreenToWorldPoint.html
public class Drag : MonoBehaviour
{
    private bool dragging = false;

    private Vector3 screenPoint;
    private Vector3 offset;

    public float speed = 500.0f;

    void OnMouseDown()
    {
        dragging = true;
        
            speed = 0.0f;
        
        
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(ToDepth(Input.mousePosition, transform.position.z));
        offset = gameObject.transform.position - cursorPosition;


    }

    void OnMouseDrag()
    {
        //speed = 500.0f;
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(ToDepth(Input.mousePosition, transform.position.z)) + offset;

        Vector3 direction = -(transform.position - cursorPosition).normalized;
        //transform.GetComponent<Rigidbody2D>().velocity = direction * speed * Time.deltaTime;
        
        if(Mathf.Round(cursorPosition.x) != Mathf.Round(Input.mousePosition.x) && Mathf.Round(cursorPosition.y) != Mathf.Round(Input.mousePosition.y) ){
            
            speed = 500.0f;
            transform.GetComponent<Rigidbody2D>().velocity = direction * speed * Time.deltaTime;
        }else if(Mathf.Round(cursorPosition.x) == Mathf.Round(Input.mousePosition.x) && Mathf.Round(cursorPosition.y) == Mathf.Round(Input.mousePosition.y) ){
            
            speed = 0.0f;
            transform.GetComponent<Rigidbody2D>().velocity = direction * speed * Time.deltaTime;
        }
    }

    void OnMouseUp()
    {
        dragging = false;
        speed = 0.0f;
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(ToDepth(Input.mousePosition, transform.position.z));

        Vector3 direction = -(transform.position - cursorPosition).normalized;
        transform.GetComponent<Rigidbody2D>().velocity = direction * speed * Time.deltaTime;
        
    }

    Vector3 ToDepth(Vector3 value, float depth)
    {
        return new Vector3(value.x, value.y, depth);
    }
}
