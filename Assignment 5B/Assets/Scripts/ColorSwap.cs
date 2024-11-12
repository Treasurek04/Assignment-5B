using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwap : MonoBehaviour
{
    public MeshRenderer box;
    public Color colorMix;
    bool swap;

   public void Start()
    {
        box.material.color = colorMix;
    }
}
