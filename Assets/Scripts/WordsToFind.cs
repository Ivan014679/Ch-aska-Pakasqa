using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsToFind : MonoBehaviour
{
    public GameObject wordsContainer;
    private bool toMove = false;
    private bool isMovingBack = false;

    private RectTransform tr;

    private float initialX;
    private float preX;
    private float finalX;

    private void Awake()
    {
        tr = (RectTransform) wordsContainer.transform;
        initialX = wordsContainer.transform.position.x;
        finalX = tr.rect.width * 3.5625f;
    }

    public void MovePanel()
    {
        toMove = true;
    }

    private void Update()
    {
        if (toMove && finalX > wordsContainer.transform.position.x && !isMovingBack && wordsContainer.transform.position.x != preX)
        {
            preX = wordsContainer.transform.position.x;
            wordsContainer.transform.position = Vector3.MoveTowards(wordsContainer.transform.position, new Vector3(finalX, wordsContainer.transform.position.y, wordsContainer.transform.position.z), Time.deltaTime * 1000);
            if (wordsContainer.transform.position.x == preX)
            {
                isMovingBack = true;
                toMove = false;
                preX = preX + 1;
            }
        }
        else if (toMove && initialX < wordsContainer.transform.position.x && isMovingBack && wordsContainer.transform.position.x != preX)
        {
            preX = wordsContainer.transform.position.x;
            wordsContainer.transform.position = Vector3.MoveTowards(wordsContainer.transform.position, new Vector3(initialX, wordsContainer.transform.position.y, wordsContainer.transform.position.z), Time.deltaTime * 1000);
        }

        if (initialX == wordsContainer.transform.position.x && isMovingBack)
        {
            toMove = false;
            isMovingBack = false;
        }
    }
}
