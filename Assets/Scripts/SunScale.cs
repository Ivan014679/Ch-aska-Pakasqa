using UnityEngine;
using UnityEngine.UI;

public class SunScale : MonoBehaviour
{
    public Slider scale;
    public GameObject sunContadero, sunPotosi;

    public void SunsScale()
    {
        sunContadero.transform.localScale = new Vector3(scale.value, scale.value, scale.value);
        sunPotosi.transform.localScale = new Vector3(scale.value, scale.value, scale.value);
    }
}
