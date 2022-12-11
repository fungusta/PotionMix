using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingPotLiquidColor : MonoBehaviour
{
    private Color color;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        //Make the starting color to grey
        color = Color.gray;
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = color;
    }

    public void ChangeColor(Color otherColor, float originalVol, float otherVol)
    {
        float otherVolumeFraction = otherVol / (otherVol + originalVol);
        float volumeFraction = originalVol / (otherVol + originalVol);
        
        Color updatedColor = otherColor * otherVolumeFraction + color * volumeFraction;
        color = updatedColor;

        sprite.color = color;
    }
}
