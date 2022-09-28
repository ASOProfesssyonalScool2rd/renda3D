using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountScripts : MonoBehaviour
{
    public int countdownMinutes = 30;

    private float countdownsecons;

    private Text Timetext;
    // Start is called before the first frame update
    void Start()
    {
        Timetext.GetComponent<Text>();
        countdownsecons = countdownMinutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        countdownsecons -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownsecons);
        Timetext.text = span.ToString(@"mm\:ss");
        if (countdownsecons <= 0)
        {
            
        }
    }
    
}
