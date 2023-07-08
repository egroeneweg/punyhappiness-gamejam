using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreakClickEvent : MonoBehaviour
{
    [SerializeField] private int baseIncrease;
    [SerializeField] private string interactType;
    private Color startcolor;
    private ChildTraitsAnxiety childTraitsAnxiety;
    private GameObject theChild;

    void Start()
    {
        // interactType = "dark" or "sound";
        theChild = GameObject.Find("Child");
        childTraitsAnxiety = theChild.GetComponent<ChildTraitsAnxiety>();
    }
    void OnMouseDown()
    {
        float distanceMod = Vector2.Distance(transform.position, theChild.transform.position);
        childTraitsAnxiety.UpdateAnxiety(baseIncrease, interactType, distanceMod);
    }
}
