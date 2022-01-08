using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraS6 : MonoBehaviour
{
    bool iscolor = true;

    void OnMouseDown()
    {
        iscolor = !iscolor;
        if (iscolor)
        {
            //GetComponent<Renderer>().material.color = Color.cyan;

        }
        else
        {
            GetComponent<Renderer>().material.color = Color.blue;
            CrearMonos.scoreMonos += "s";
        }
    }
}
