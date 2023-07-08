using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child
{
    private string childName;
    public string Name => childName;
    private string childAge;
    public string Age => childAge;
    private string childFlavour;
    public string Flavourtext => childFlavour;
    private float soundMod;
    public float SoundModifier => soundMod;
    private float darkMod;
    public float DarknessModifier => darkMod;
    private int startingAnxiety;
    public int StartingAnxiety => startingAnxiety;
    private float anxietyTickdownRate;
    public float AnxietyTickdownRate => anxietyTickdownRate;

    private string[] ChildNames = new string[] {"Jemimah", "Liam", "Emma"};

    public Child()
    {
        SelectChild(ChildNames[Random.Range(0, ChildNames.Length - 1)]);
    }

    private void SelectChild(string name)
    {
        switch (name)
        {
            case "Jemimah":
                childName = "Jemimah";
                childAge = "5";
                childFlavour = "Subject Jemimah is not gonna be too challenging, perfect for a first-time rookie like you! Jemimah always has to keep his eyes out, cause he's kinda hard of hearing.";
                soundMod = 0.2f;
                darkMod = 0.7f;
                startingAnxiety = 25;
                anxietyTickdownRate = 0.15f;
                break;
            case "Liam":
                childName = "Liam";
                childAge = "7";
                childFlavour = "Subject Liam is another great first-time subject. He's recently lost his glasses, so he's a bit blind. He likes the dark but hates loud and sudden noises.";
                soundMod = 0.7f;
                darkMod = 0.2f;
                startingAnxiety = 25;
                anxietyTickdownRate = 0.15f;
                break;
            case "Emma":
                childName = "Emma";
                childAge = "11";
                childFlavour = "Subject Emma is our toughest nut to crack. She's older and has one of them newfangled smartphone devices. She's constantly staring down at it, with her earphones in, so it's gonna be a bit of a challenge to get her attention. Best of luck!";
                soundMod = 0.1f;
                darkMod = 0.1f;
                startingAnxiety = 10;
                anxietyTickdownRate = 0.3f;
                break;
        }
    }
}
