using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearMachines : MonoBehaviour
{
    public Text TextScore;

    public static CrearMachines Gamecontroller;

    public static String scoreMachines = "";

    private void Update()
    {
        if (scoreMachines.Equals("machines"))
        {
            TextScore.gameObject.SetActive(true);
        }

    }

    private void Awake()
    {
        Gamecontroller = this;
    }
}
