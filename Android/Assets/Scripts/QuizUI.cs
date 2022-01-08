using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Text m_pregunta = null;
    [SerializeField] private List<OpcionBoton> m_listaBoton = null;

    public void Constructr(Pregunta p, Action<OpcionBoton> callback)
    {
        if (p) {
            m_pregunta.text = p.text;
            for (int n = 0; n < m_listaBoton.Count; n++)
            {
                m_listaBoton[n].Constructr(p.respuestas[n], callback);
            }
        }
    }
}
