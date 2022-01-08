using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraELE : MonoBehaviour
{
    bool iscolor = true;

    void OnMouseDown()
    {
        iscolor = !iscolor;
        if (iscolor)
        {
            GetComponent<Renderer>().material.color = Color.cyan;

        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
            CrearTexto.scorePetroglifo += "l";
        }
    }
}
