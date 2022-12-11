using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingPot : MonoBehaviour
{
    private float volume;
    public CookingPotLiquidColor liquidColor;
    private static readonly float ADDING_VOLUME = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        volume = 0f;
        liquidColor = FindObjectOfType<CookingPotLiquidColor>();
    }

    public void AddElement(Element element)
    {
        ChangeLiquidColor(element.GetColor(), ADDING_VOLUME);
    }

    private void ChangeLiquidColor(Color otherColor, float otherVolume)
    {
        liquidColor.ChangeColor(otherColor, volume, otherVolume);
        volume += otherVolume;
    }
}
