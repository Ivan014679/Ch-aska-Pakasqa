using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraO3 : MonoBehaviour
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
            GetComponent<Renderer>().material.color = Color.white;
            CrearPalabr.scorePictografo += "o";
        }
    }
}
