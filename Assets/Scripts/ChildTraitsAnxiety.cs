using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTraitsAnxiety : MonoBehaviour
{
    [SerializeField] private string childName;
    [SerializeField] private int currentAnxiety;
    private float ticDown;
    private Child currentChild;

    void Start()
    {
        currentChild = new Child();
        childName = currentChild.Name;
        currentAnxiety = currentChild.StartingAnxiety;
        ticDown = 0;
    }
    void Update()
    {
        if(currentAnxiety > currentChild.StartingAnxiety)
        {
            ticDown += currentChild.AnxietyTickdownRate * Time.deltaTime;
            if(ticDown >= 1)
            {
                currentAnxiety -= 1;
                ticDown = 0;
            }
        }
        else
        {
            currentAnxiety = currentChild.StartingAnxiety;
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
