using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolmaker : MonoBehaviour
{

    public Transform spawnpoint;

    public GameObject chisel;

    public GameObject brush;

    private GameObject instantiateObject;

    private Material instantiateMaterial;

    public void ChiselBOY()
    {
        instantiateObject = chisel;
    }

    public void BrushBOY()
    {
        instantiateObject = brush;
    }

    public void Spawn()
    {
        GameObject newspawn = Instantiate(instantiateObject, spawnpoint.position, Quaternion.identity);
    }
}
