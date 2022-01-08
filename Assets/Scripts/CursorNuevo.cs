using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorNuevo : MonoBehaviour
{
    public int tamañoCursor = 32;
    public Texture2D cucharaCursor, normalCursor;
    Texture2D cursorActivo;

    private void Start()
    {
        Cursor.visible = false;
        cursorCambiar("normal");
    }

    public void cursorCambiar(string tipoCursor)
    {
        if (tipoCursor == "normal")
        {
            cursorActivo = normalCursor;
        }
        if (tipoCursor == "cuchara")
        {
            cursorActivo = cucharaCursor;
        }
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, tamañoCursor, tamañoCursor), cursorActivo);
    }
}
