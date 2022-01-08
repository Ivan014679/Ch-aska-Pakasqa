using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class CrearMonos : MonoBehaviour
{
    public Text TextScore;

    public static CrearMonos Gamecontroller;

    public static String scoreMonos = "";

    private void Update()
    {
        if (scoreMonos.Equals("monos"))
        {
            TextScore.gameObject.SetActive(true);
        }

    }

    private void Awake()
    {
        Gamecontroller = this;
    }

}
