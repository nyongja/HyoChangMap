using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroDialog : MonoBehaviour {

    public GPSCheck gc;
    public int page = 0;
    public Canvas mc;   //mapCanvas
    public string NextSceneString;
    public Canvas guide;    //guideCanvas
    public Canvas dc;//dialog canvas
    public RawImage before;
    public RawImage next;
    public RawImage Dialog_1;
    public RawImage Dialog_2;
    public RawImage Dialog_3;
    public AudioSource movebgm;
    public AudioSource mainbgm;
    bool bgmplay = true;
    // Use this for initialization
    void Start () {
        guide.gameObject.SetActive(false);
        mc.gameObject.SetActive(false);
        Dialog_2.gameObject.SetActive(false);
        Dialog_3.gameObject.SetActive(false);
        mainbgm.GetComponent<AudioSource>().Play();
        movebgm.GetComponent<AudioSource>().Stop();
    }
	
	// Update is called once per frame
	void Update () {
        
        switch (page)
        {
            case 0:
                Dialog_1.gameObject.SetActive(true);
                Dialog_2.gameObject.SetActive(false);
                before.gameObject.SetActive(false);
                break;
            case 1:
                Dialog_2.gameObject.SetActive(true);
                Dialog_1.gameObject.SetActive(false);
                Dialog_3.gameObject.SetActive(false);
                before.gameObject.SetActive(true);
                break;
            case 2:
                Dialog_3.gameObject.SetActive(true);
                Dialog_2.gameObject.SetActive(false);
                break;
            case 3:
                mainbgm.GetComponent<AudioSource>().Stop();
                if (bgmplay) {
                    movebgm.GetComponent<AudioSource>().Play();
                    movebgm.GetComponent<AudioSource>().loop = true;
                    bgmplay = false;
                }
                
                guide.gameObject.SetActive(true);
                dc.gameObject.SetActive(false);
                if (gc.current_Lat>=0){
                    //gc.current_Lat >= 36.675 && gc.current_Lat <=37.678 && gc.current_Long>=126.73 && gc.current_Long<=126.75
                    Application.LoadLevel(NextSceneString);
                }
                break;
        }
	}
}
