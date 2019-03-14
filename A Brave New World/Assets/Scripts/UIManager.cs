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

    public TimeCheck timeCheck;

    private void Awake()
    {

    }

    private void Start()
    {
        // Change where this actually starts.        
        timeCheck.StartTime();
        UpdateTimeUI();
        UpdatePeriodUI(1);
        UpdateDayUI();
    }

    void Update()
    {
        
    }

    public void UpdateTimeUI ()
    {
        txt_minute.text = timeCheck.Int_minute.ToString();
        if(timeCheck.Int_hour >=24)
        {
            var newTime = timeCheck.Int_hour - 24;
            txt_hour.text =newTime.ToString();
        }
        else
        {
            txt_hour.text = timeCheck.Int_hour.ToString();
        }        
    }

    public void UpdateDayUI()
    {
        txt_day.text = timeCheck.Int_day.ToString();
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
