using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreguntaDB : MonoBehaviour
{
    [SerializeField] private List<Pregunta> listapreguntas = null;

    [SerializeField] private Text questionTitle, score;
    [SerializeField] private GameObject questionPanel, resultsPanel;

    private List<Pregunta> m_backup = null;
    private int[] nQuestions;
    private int currentQuestion;
    private int nQuestion;

    private void Awake()
    {
        m_backup = listapreguntas; 
    }

    private void Start()
    {
        nQuestions = getUniqueRandomArray(0, listapreguntas.Count, listapreguntas.Count);
        currentQuestion = 0;
        nQuestion = 0;
    }

    public Pregunta GetRandom(bool remover = true)
    {
        nQuestion++;

        if (nQuestion <= listapreguntas.Count)
        {
            if (listapreguntas.Count == 0)
                RestoreBackup();

            int index = nQuestions[currentQuestion];
            currentQuestion++;

            if (!remover)
                return listapreguntas[index];

            Pregunta p = listapreguntas[index];

            questionTitle.text = questionTitle.text.Split(' ')[0] + " " + nQuestion;
            //listapreguntas.RemoveAt(index);
            return p;
        }
        else
        {
            questionPanel.SetActive(false);
            resultsPanel.SetActive(true);

            score.text = ManagerJuego.score + "/" + listapreguntas.Count;

            return null;
        }
    }

    private void RestoreBackup()
    {
        listapreguntas = m_backup;
    }

    private static int[] getUniqueRandomArray(int min, int max, int count)
    {
        int[] result = new int[count];
        List<int> numbersInOrder = new List<int>();
        for (var x = min; x < max; x++)
        {
            numbersInOrder.Add(x);
        }
        for (var x = 0; x < count; x++)
        {
            var randomIndex = Random.Range(0, numbersInOrder.Count);
            result[x] = numbersInOrder[randomIndex];
            numbersInOrder.RemoveAt(randomIndex);
        }

        return result;
    }
}
