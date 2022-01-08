using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearInty : MonoBehaviour
{
    public Text TextScore;

    public static CrearInty Gamecontroller;

    public static String scoreInti = "";

    private void Update()
    {
        if (scoreInti.Equals("intiraymi"))
        {
            TextScore.gameObject.SetActive(true);
        }

    }

    private void Awake()
    {
        Gamecontroller = this;
    }
}
