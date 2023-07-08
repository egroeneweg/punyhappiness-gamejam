using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public float soundModifier;
    public float darknessModifier;
    public Child currentChild;
    public static int currentAnxiety;
    [SerializeField] private float anxietyTickdownRate = 0.1f;
    void Start()
    {
        currentChild = new Child(name="Jemimah");
        soundModifier = currentChild.SoundModifier;
        darknessModifier = currentChild.DarknessModifier;
        currentAnxiety = 0;
    }

    // Anxiety update method to be called by objects being interacted with by the player
    public void UpdateAnxiety(int baseIncrease, string interactType, float distanceMod)
    {
        switch (interactType)
        {
            case "sound":
                currentAnxiety += (int)(baseIncrease * soundModifier * distanceMod);
                break;
            case "dark":
                currentAnxiety += (int)(baseIncrease * darknessModifier * distanceMod);
                break;
            default:
                break;
        }
        Debug.Log("Anxiety is now " + currentAnxiety);
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
}
