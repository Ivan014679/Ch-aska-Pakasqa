using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reloj : MonoBehaviour
{
    [Tooltip("Tiempo iniciar en Segundos")]
    public int tiempoinicial;
    [Tooltip("Escala del Tiempo del Reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = 1;

    private Text myText=null;
    private float TiempoFrameConTiempoScale = 0f;
    private float tiempoMostrarEnSegundos = 0F;
    private float escalaDeTiempoInicial;
    string textoDelReloj;
    public GameObject managerJuego;

    void Start()
    {
       escalaDeTiempoInicial = escalaDeTiempo;

        myText = GetComponent<Text>();
        
        tiempoMostrarEnSegundos = tiempoinicial;

        ActualizarReloj(tiempoinicial);
    }

    public void Update()
    {
        TiempoFrameConTiempoScale = Time.deltaTime * escalaDeTiempo;
        tiempoMostrarEnSegundos += TiempoFrameConTiempoScale;
      
            ActualizarReloj(tiempoMostrarEnSegundos);
     
    }

    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        // int milisegundos = 0;
        

        if (tiempoEnSegundos <= 0)
        {
            Reiniciar();
            managerJuego.SendMessage("SiguientePregunta");

        }
           


        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;
        //milisegundos = (int)tiempoEnSegundos / 1000;

        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00"); //+ ":" + milisegundos.ToString("00");
        myText.text = textoDelReloj;
    }
    
    public void Reiniciar()
    {
        escalaDeTiempo = escalaDeTiempoInicial;
        tiempoMostrarEnSegundos = tiempoinicial;
        ActualizarReloj(tiempoMostrarEnSegundos);
    }

}
