using System.Collections;
using System.Collections.Generic;

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

    public Child(string name)
    {
        childName = name;
        childAge = "5";
        childFlavour = "Subject Jemimah is not gonna be too challenging, perfect for a first-time rookie like you! He's deaf.";
        soundMod = 0.0f;
        darkMod = 0.6f; 
    }
}
