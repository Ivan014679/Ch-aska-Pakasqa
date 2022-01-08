using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ManagerJuego : MonoBehaviour
{
    
    [SerializeField] private AudioClip sonidoCorrecto = null;
    [SerializeField] private AudioClip sonidoIncorrecto = null;
    [SerializeField] private Color colorCorrecto = Color.black;
    [SerializeField] private Color colorIncorrecto = Color.black;
    [SerializeField] private float tiempoEspera = 2.5f;

    private PreguntaDB m_preguntaDB = null;
    private QuizUI m_quizUI = null;
    private AudioSource m_audioSourse = null;

    public static int score, prescore;

    public GameObject Contador;    

    private void Start()
    {
        score = 0;
        m_preguntaDB = FindObjectOfType<PreguntaDB>();
        m_quizUI = FindObjectOfType<QuizUI>();
        m_audioSourse = GetComponent<AudioSource>();

             
        SiguientePregunta();
    }

    private void SiguientePregunta()
    {
        m_quizUI.Constructr(m_preguntaDB.GetRandom(), DarRespuesta);
    }

    private void DarRespuesta(OpcionBoton opcionboton)
    {
        StartCoroutine(DarRespuestaRoutine(opcionboton));
        //CalcularRespuesta(opcionboton);
    }


    private void CalcularRespuesta(OpcionBoton opcionBoton)
    {
        if (m_audioSourse.isPlaying)
            m_audioSourse.Stop();

        m_audioSourse.clip = opcionBoton.respuesta1.correcta ? sonidoCorrecto : sonidoIncorrecto;
        opcionBoton.SetColor(opcionBoton.respuesta1.correcta ? colorCorrecto : colorIncorrecto);
        prescore = prescore + 1;
        score = opcionBoton.respuesta1.correcta ? prescore : score;
        Debug.Log(score);

        m_audioSourse.Play();
    }
    private IEnumerator DarRespuestaRoutine(OpcionBoton opcionBoton)
    {
        CalcularRespuesta(opcionBoton);

        yield return new WaitForSeconds(tiempoEspera);
        //Contador.SendMessage("Reiniciar");
        prescore = 0;
        Debug.Log("aada");
        //SiguientePregunta(); 
    }
}
