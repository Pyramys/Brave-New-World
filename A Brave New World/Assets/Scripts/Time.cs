using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    // This script controls the time part of the game.
    // Contains variables and methods for like time.
    // It needs ways to pull that info for various other classes.
    private int int_hour=6;
    private int int_minute=0;
    private int int_day = 1;
    private int int_period = 1;
    // Variable to control the speed of time.
    [SerializeField] private float flt_timeSpeed =1;

    public int Int_hour
    {
        get
        {
            return int_hour;
        }

        set
        {
            int_hour = value;
        }
    }
    public int Int_minute
    {
        get
        {
            return int_minute;
        }

        set
        {
            int_minute = value;
        }
    }
    public int Int_day
    {
        get
        {
            return int_day;
        }

        set
        {
            int_day = value;
        }
    }
    public int Int_period
    {
        get
        {
            return int_period;
        }

        set
        {
            int_period = value;
        }
    }
    public float Flt_timeSpeed
    {
        get
        {
            return flt_timeSpeed;
        }

        set
        {
            flt_timeSpeed = value;
        }
    }

    public void StartTime()
    {
        InvokeRepeating("FlowOfTime", 1, flt_timeSpeed);
    }

    public void PauseTime()
    {
        CancelInvoke();
    }

    public void ResumeTime()
    {
        InvokeRepeating("FlowOfTime", 1, flt_timeSpeed);
    }

    void FlowOfTime()
    {
        Debug.Log("here");
        Int_minute += 10;
        if(Int_minute >= 60)
        {
            Int_minute = 0;
            Int_hour += 1;
            // Force end of day.
            if(Int_hour >= 27)
            {
                Int_hour = 6;
                int_day += 1;
                PeriodChange();
                // Method for handling end of day events.
            }
        }
    }

    void PeriodChange()
    {
        // This method handles period changing and events associated with them.
        // It calls the quest manager's resolve period quests method.
        switch (int_period)
        {
            case 1:
                {
                    if (int_day >= 3)
                    {
                        int_period += 1;
                    }
                    break;
                }
            case 2:
                {
                    if(int_day >= 7)
                    {
                        int_period += 2;
                    }
                    break;
                }
           default:
                {
                    Debug.Log("Could not resolve period change");
                    break;
                }
        }
    }
}
