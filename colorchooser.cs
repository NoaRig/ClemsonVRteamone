using UnityEngine;
using System;

public class ColorChooser5 : MonoBehaviour
{
    public MeshRenderer target;
    public Color[] colors = new Color[0];

    public void SetColor(float index)
    {
        if (index < 0 || index >= colors.Length)
        {
            return;
        }

        target.material.color = colors[(int)index];
    }
    public void TesterMethod()
    {
        Console.WriteLine("Passed!");
        return;
    }
}
