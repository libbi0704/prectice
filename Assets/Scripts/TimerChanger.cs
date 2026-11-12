using System.Threading;
using TMPro;
using UnityEngine;

public class TimerChanger : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    float time=0;
    int sec=0;
    bool try0 = true;
    void Update()
    {
    
        if (try0 == true)
        {
                    time +=Time.deltaTime*30;
        TimerText.text = sec.ToString("00")+" : "+ Mathf.FloorToInt(time).ToString("00");

        if (time >= 60)
        {
            time-=60;
            sec++;
        }
        }
        if (sec == 6 && time >= 15)
        {
            TimerText.text="STOP";
            try0 = false;

        }
    }
}
