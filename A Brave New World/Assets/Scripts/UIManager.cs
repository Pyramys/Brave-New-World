using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Text txt_day;
    public Text txt_minute;
    public Text txt_hour;
    public Text txt_period;

    public Time time;

    private void Awake()
    {
        txt_day.text = "01";
        txt_period.text = "Landing";
    }

    private void Start()
    {
        // Change where this actually starts.        
        time.StartTime();
    }

    void Update()
    {
        UpdateTimeUI();
    }

    private void UpdateTimeUI ()
    {
        txt_minute.text = time.Int_minute.ToString();
        txt_hour.text = time.Int_hour.ToString();
    }
}
