using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class CreakClickEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private int baseIncrease = 10;
    private Color startcolor;
    private ChildTraitsAnxiety childTraitsAnxiety;
    private GameObject theChild;
    private TextMeshProUGUI clickText;

    void Start()
    {
        theChild = GameObject.Find("Child");
        childTraitsAnxiety = theChild.GetComponent<ChildTraitsAnxiety>();
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).name == "Text (TMP)")
            {
                Debug.Log("Found Text");
                clickText = transform.GetChild(i).gameObject.GetComponent<TextMeshProUGUI>();
            }
        }
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Pointer Entering " + gameObject.name);
        Material fontMaterial = clickText.fontMaterial;
        Debug.Log(fontMaterial);
        clickText.fontMaterial.SetFloat(ShaderUtilities.ID_GlowPower, 1.0f);
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        clickText.fontMaterial.SetFloat(ShaderUtilities.ID_GlowPower, 0.0f);
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        float distanceMod = Vector2.Distance(transform.position, theChild.transform.position);
        childTraitsAnxiety.UpdateAnxiety(baseIncrease, "sound", distanceMod);
    }
}
