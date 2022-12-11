using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public enum ElementTypes
    {
        WATER, FIRE, EARTH, ICE, AIR
    }

    private ElementTypes type;

    public Element(ElementTypes type)
    {
        this.type = type;
    }

    public Color GetColor()
    {
        switch(type)
        {
            case ElementTypes.WATER:
                return Color.blue;
            case ElementTypes.FIRE:
                return Color.red;
            case ElementTypes.EARTH:
                return Color.green;
            case ElementTypes.ICE:
                return Color.cyan;
            case ElementTypes.AIR:
                return Color.white;
            default:
                return Color.black; //Should not occur
        }
    }
}
