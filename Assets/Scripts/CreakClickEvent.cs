using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreakClickEvent : MonoBehaviour
{
    [SerializeField] private int baseIncrease = 10;
    private Color startcolor;
    void OnMouseEnter()
    {
        // add yellow outline to the object   
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startcolor;
    }
    void OnMouseDown()
    {
        float distanceMod = Vector2.Distance(transform.position, GameObject.Find("Boy").transform.position);
        transform.parent.GetComponent<ObjectManager>().UpdateAnxiety(baseIncrease, "sound", distanceMod);
    }
}
