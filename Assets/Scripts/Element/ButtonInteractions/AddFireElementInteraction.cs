using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Element;

public class AddFireElementInteraction : AddElementInteraction
{
    readonly Element element = new Element(ElementTypes.FIRE);

    public override void OnClickAddElement()
    {
        CookingPot cookingPot = FindObjectOfType<CookingPot>();
        cookingPot.AddElement(element);
    }
}
