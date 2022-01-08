using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraT : MonoBehaviour
{
    bool iscolor = false;

    void OnMouseDown()
    {
        
        
        if (iscolor)
        {
            Debug.Log("Hgfgd");
            GetComponent<Renderer>().material.color = Color.cyan;
            iscolor = !iscolor;
        }
        else
        {
            Debug.Log("fffffff");
            GetComponent<Renderer>().material.color = Color.red;
            CrearTexto.scorePetroglifo += "t";
            iscolor = !iscolor;
        }
    }
}
