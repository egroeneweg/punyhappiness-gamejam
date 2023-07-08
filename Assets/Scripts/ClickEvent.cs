using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    private Color startcolor;
    void OnMouseEnter()
    {
        // add red outline to the object   
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startcolor;
    }
    void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name);
    }
}
