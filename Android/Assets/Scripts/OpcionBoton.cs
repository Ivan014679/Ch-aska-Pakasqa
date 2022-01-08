using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class OpcionBoton : MonoBehaviour
{
    private Text m_texto = null;
    public Button m_boton = null;
    private Image imagen = null;
    private Color colorImagenOr = Color.black;

    public Respuesta respuesta1  { get; set; }

    private void Awake()
    {
        m_boton = GetComponent<Button>();
        imagen = GetComponent<Image>();
        m_texto = transform.GetChild(0).GetComponent<Text>();
        colorImagenOr = imagen.color;
    }
    
    public void Constructr(Respuesta respuesta, Action<OpcionBoton> callback)
    {
        m_texto.text = respuesta.text;
        m_boton.enabled = true;
        imagen.color = colorImagenOr;

        respuesta1 = respuesta;

        m_boton.onClick.AddListener(delegate
        {
            callback(this);
        });
    }

    public void SetColor(Color color)
    {
       m_boton.enabled = false;
        imagen.color = color;
    }

}
