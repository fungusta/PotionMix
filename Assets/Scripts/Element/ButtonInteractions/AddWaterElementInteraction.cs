using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Element;

public class AddWaterElementInteraction : AddElementInteraction
{
    readonly Element element = new Element(ElementTypes.WATER);

    public override void OnClickAddElement()
    {
        CookingPot cookingPot = FindObjectOfType<CookingPot>();
        cookingPot.AddElement(element);
    }
}