using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateChanged : MonoBehaviour
{
    public Dropdown day, month;
    public Slider speed;
    public GameObject sunContadero, sunPotosi;

    [SerializeField] private Vector3 rotation;

    private void Awake()
    {
        day.AddOptions(GetDays());
    }
    
    public void RestartDays()
    {
        day.ClearOptions();
        day.AddOptions(GetDays());
    }

    public void DeclinateSun()
    {
        float diaryAngle = ((2 * Mathf.PI) / 365) * (GetTotalDays() - 1);
        double declinationAngle = 0.006918 - 0.399912 * Mathf.Cos(diaryAngle) + 0.070257 * Mathf.Sin(diaryAngle) - 0.00006758 * Mathf.Cos(2 * diaryAngle) + 0.000907 * Mathf.Sin(2 * diaryAngle) - 0.002697 * Mathf.Cos(3 * diaryAngle) + 0.00148 * Mathf.Sin(3 * diaryAngle);
        sunContadero.transform.localRotation = Quaternion.Euler(new Vector3((float) (Mathf.Rad2Deg * declinationAngle), sunContadero.transform.localPosition.y, sunContadero.transform.localPosition.z));
        sunPotosi.transform.localRotation = Quaternion.Euler(new Vector3((float)(Mathf.Rad2Deg * declinationAngle), sunPotosi.transform.localPosition.y, sunPotosi.transform.localPosition.z));
    }

    private List<string> GetDays()
    {
        List<string> days = new List<string>();
        int daysAmount = DateTime.DaysInMonth(1998, month.value + 1);
        for (int i = 1; i <= daysAmount; i++)
        {
            days.Add(i.ToString());
        }
        return days;
    }

    private int GetTotalDays()
    {
        int totalDays = 0;
        
        for (int i = 1; i < month.value + 1; i++)
        {
            totalDays = totalDays + DateTime.DaysInMonth(1998, i);
        }
        totalDays = totalDays + int.Parse(day.options[day.value].text);

        return totalDays;
    }

    private void Update()
    {
        sunContadero.transform.Rotate(rotation * speed.value * Time.deltaTime);
        sunPotosi.transform.Rotate(rotation * speed.value * Time.deltaTime);
    }
}
