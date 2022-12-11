using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Element;

public class AddEarthElementInteraction : AddElementInteraction
{
    readonly Element element = new Element(ElementTypes.EARTH);

    public override void OnClickAddElement()
    {
        CookingPot cookingPot = FindObjectOfType<CookingPot>();
        cookingPot.AddElement(element);
    }
}
