using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingPotDiscardInteraction : MonoBehaviour
{
    public void OnClickDiscard()
    {
        CookingPot cookingPot = FindObjectOfType<CookingPot>();
        cookingPot.DiscardContents();
    }
}
