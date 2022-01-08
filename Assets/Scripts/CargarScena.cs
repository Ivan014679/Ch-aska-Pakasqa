using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarScena : MonoBehaviour
{
    public void CargaEscena(string cargar)
    {
        SceneManager.LoadScene(cargar);
    }

}
