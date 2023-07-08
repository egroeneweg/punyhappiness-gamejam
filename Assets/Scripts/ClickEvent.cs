using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name);
    }
}
