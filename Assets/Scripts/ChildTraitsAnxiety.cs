using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTraitsAnxiety : MonoBehaviour
{
    [SerializeField] private string childName = "Jemimah";
    [SerializeField] private float anxietyTickdownRate = 0.1f;
    private Child currentChild;
    private int currentAnxiety = 0;

    void Start()
    {
        currentChild = new Child(childName);
    }
    void Update()
    {
        if(currentAnxiety > 0)
        {
            currentAnxiety -= (int)(anxietyTickdownRate * Time.deltaTime);
        }
        else
        {
            currentAnxiety = 0;
        }
    }
    public void UpdateAnxiety(int baseIncrease, string interactType, float distanceMod)
    {
        switch (interactType)
        {
            case "sound":
                currentAnxiety += (int)(baseIncrease * currentChild.SoundModifier * distanceMod);
                break;
            case "dark":
                currentAnxiety += (int)(baseIncrease * currentChild.DarknessModifier * distanceMod);
                break;
            default:
                break;
        }
        Debug.Log("Anxiety is now " + currentAnxiety);
    }
}
