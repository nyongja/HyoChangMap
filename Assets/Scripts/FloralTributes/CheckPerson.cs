using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPerson : MonoBehaviour {
    //select person 고르기
    public Canvas gc;   //guide canvas
    public Canvas mc;   //map canvas

    public GPSCheck gps;
    public RawImage kmb;//KimguMapBtn
    public RawImage emb;//EtcMapBtn

    public RawImage thomb;
    public RawImage tribute;
    public RawImage kmoveGuide;
    public RawImage emoveGuide;
    public SelectChar sc;

    public RawImage arrow;
    public MoveFlower mf;
    float time = 0f;
	// Use this for initialization
	void Start () {
        mc.gameObject.SetActive(false);
        arrow.gameObject.SetActive(false);
        kmoveGuide.gameObject.SetActive(false);
        kmoveGuide.gameObject.SetActive(false);
        thomb.gameObject.SetActive(false);
        tribute.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //MoveGuide수정하기(김구일때 그 외일때), MapBtn도 수정하기
        
        if (gps.current_Lat >= 0 && SelectChar.charSelect == 1)
        //GPSCheck.current_Lat >= 37.5451 && GPSCheck.current_Lat < 37.5453 && GPSCheck.current_Long >= 126.958 && GPSCheck.current_Long < 126.960 && SelectChar.charSelect == 1
        //백범김구37.545253, 126.959656
        {
            thomb.gameObject.SetActive(true);

            mc.gameObject.SetActive(false);
            kmb.gameObject.SetActive(false);
            emb.gameObject.SetActive(false);

           
            time += Time.deltaTime;
            if (time >= 1.5f )
            {
                thomb.gameObject.SetActive(false);
                tribute.gameObject.SetActive(true);
                arrow.gameObject.SetActive(true);
                Destroy(kmoveGuide, 1.5f);
                Destroy(arrow, 1.5f);
                mf.is_emerge = true;
            }

        } else if (SelectChar.charSelect!= 1 && gps.current_Lat >= 0) {
            //GPSCheck.current_Lat >= 37.5447 && GPSCheck.current_Lat < 37.54449 && GPSCheck.current_Long >= 126.960 && GPSCheck.current_Long < 126.962
            //그 외  37.544875, 126.96168
            thomb.gameObject.SetActive(true);

            mc.gameObject.SetActive(false);
            kmb.gameObject.SetActive(false);
            emb.gameObject.SetActive(false);


            time += Time.deltaTime;
            if (time >= 1.5f)
            {
                thomb.gameObject.SetActive(false);
                tribute.gameObject.SetActive(true);
                arrow.gameObject.SetActive(true);
                Destroy(emoveGuide, 1.5f);
                Destroy(arrow, 1.5f);
                mf.is_emerge = true;
            }
        } else if (SelectChar.charSelect == 1)
        {
            kmoveGuide.gameObject.SetActive(true);
            kmb.gameObject.SetActive(true);
        }
        else
        {
            emoveGuide.gameObject.SetActive(true);
            emb.gameObject.SetActive(true);
        }

       
	}
}
