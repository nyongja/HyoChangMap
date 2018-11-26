using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test: MonoBehaviour
{
    public GPSCheck gc;
    public Text t;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text text = t.GetComponent<Text>();
        Debug.Log(gc.current_Lat + ", " + gc.current_Long);
        text.text = gc.current_Lat + ", " + gc.current_Long;
    }
}
