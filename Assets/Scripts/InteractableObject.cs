using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    
    private GameObject childCanvas;
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).name == "Canvas")
            {
                childCanvas = transform.GetChild(i).gameObject;
                childCanvas.SetActive(false);
            }
        }
    }

    void OnMouseDown()
    {
        childCanvas.SetActive(true);
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        childCanvas.SetActive(false);
    }
}
