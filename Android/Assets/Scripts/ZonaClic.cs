using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaClic : MonoBehaviour
{
    public CursorNuevo cursornuevo;

    private void OnMouseEnter()
    {
        cursornuevo.cursorCambiar("cuchara");
    }

    private void OnMouseExit()
    {
        cursornuevo.cursorCambiar("normal");
    }


}
