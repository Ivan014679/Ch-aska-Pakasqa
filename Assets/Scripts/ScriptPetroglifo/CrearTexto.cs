using Mono.Data.Sqlite;
using System;
using System.Data;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CrearTexto : MonoBehaviour, IPointerEnterHandler
{
    public Text TextScore;
    
    public static CrearTexto Gamecontroller;

    public static String scorePetroglifo = "";

    private void Update()
    {
        if (scorePetroglifo.Equals("petroglifo"))
        {
            TextScore.gameObject.SetActive(true);
        }
        
    }

    private void Awake()
    {
        Gamecontroller = this;
    }
    
    

    public void OnPointerEnter(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
