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

    public TimeFlow timeFlow;

    private void Awake()
    {

    }

    private void Start()
    {
        // Change where this actually starts.        
        timeFlow.StartTime();
        UpdateTimeUI();
        UpdatePeriodUI(1);
        UpdateDayUI();
    }

    void Update()
    {
        
    }

    public void UpdateTimeUI ()
    {
        txt_minute.text = timeFlow.Int_minute.ToString();
        if(timeFlow.Int_hour >=24)
        {
            var newTime = timeFlow.Int_hour - 24;
            txt_hour.text =newTime.ToString();
        }
        else
        {
            txt_hour.text = timeFlow.Int_hour.ToString();
        }        
    }

    public void UpdateDayUI()
    {
        txt_day.text = timeFlow.Int_day.ToString();
    }

    public void UpdatePeriodUI(int num)
    {
        switch (num)
        {
            case 1:
                {
                    txt_period.text = "Landing";
                    break;
                }
            case 2:
                {
                    txt_period.text = "Early Beginnings";
                    break;
                }
            default:
                {
                    Debug.Log("Could not resolve period UI update");
                    break;
                }
        }
    }
}
