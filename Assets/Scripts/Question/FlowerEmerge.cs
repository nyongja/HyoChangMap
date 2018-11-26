using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerEmerge : MonoBehaviour {
    public AudioSource completesound;
    public GPSCheck gc;
    public Canvas getc;//getCanvas
    public Canvas guidec;
    public GameObject flower_1;
    public GameObject flower_2;
    public GameObject flower_3;
    public GameObject flower_4;
    public GameObject flower_5;
    public GameObject flower_6;
    public GameObject flower_7;
    public string NextSceneString;
    public RandomQuiz rq;
    public RawImage moveGuide;
    public RawImage flowerGuide;
    public int wrong;  //틀린 개수
    bool bgmplay = true;
    public int spotNum; //스팟 위치
    public RawImage flowerflag;

	// Use this for initialization
	void Start () {
        flower_1.gameObject.SetActive(false);
        flower_2.gameObject.SetActive(false);
        flower_3.gameObject.SetActive(false);
        flower_4.gameObject.SetActive(false);
        flower_5.gameObject.SetActive(false);
        flower_6.gameObject.SetActive(false);
        flower_7.gameObject.SetActive(false);
        wrong = 0;
        guidec.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("wrong:" + wrong);
        Debug.Log("spotnum" + spotNum);
        //문제 맞춘 개수 5개 이하일때만 꽃 등장
        if (rq.right_num < 5) {
            Debug.Log("Here?1");
            if (rq.right_num == 0){//광복70주년광장
                flower_1.gameObject.SetActive(true);
                spotNum = 0;
                //gps.lat >= 37.5454 && gps.lat <= 37.5456 && gps.lon >=126.9609 && gps.lon <= 126.9611
                //gps.lat >= 37.6785&& gps.lat <= 37.6787 && gps.lon >=126.7479 && gps.lon <= 126.7481

                //GPSCheck.current_Lat >= 37.5453 && GPSCheck.current_Lat < 37.5455 && GPSCheck.current_Long >= 126.960 && GPSCheck.current_Long <= 126.962

                //&& GPSCheck.current_Lat >= 37.675 && GPSCheck.current_Lat <= 37.679 && GPSCheck.current_Long >= 126.74 && GPSCheck.current_Long <= 126.76
            }
            if (rq.right_num==1)//백범김구묘역
            {
                Debug.Log("여기니?");
                flower_2.gameObject.SetActive(true);
                spotNum = 1;

                //GPSCheck.current_Lat >= 37.5446 && GPSCheck.current_Lat < 37.5448 && GPSCheck.current_Long >= 126.959 && GPSCheck.current_Long <= 126.961


                //&& GPSCheck.current_Lat >= 37.541 && GPSCheck.current_Lat <= 37.545 && GPSCheck.current_Long >= 126.95 && GPSCheck.current_Long < 126.97
            }
            if (rq.right_num == 2)//상징조형물
            {
                flower_3.gameObject.SetActive(true);
                spotNum = 2;

                //GPSCheck.current_Lat >= 37.5447 && GPSCheck.current_Lat < 37.5449 && GPSCheck.current_Long >= 126.961 && GPSCheck.current_Long < 126.963


                //&& GPSCheck.current_Lat >= 37.541 && GPSCheck.current_Lat <= 37.547 && GPSCheck.current_Long >= 126.96 && GPSCheck.current_Long <= 126.97
            }
            if (rq.right_num == 3)//의열사앞
            {
                flower_4.gameObject.SetActive(true);
                spotNum = 3;

                //GPSCheck.current_Lat >= 37.5448 && GPSCheck.current_Lat < 37.5450 && GPSCheck.current_Long >= 126.959 && GPSCheck.current_Long < 126.961


                //&& GPSCheck.current_Lat >= 37.541 && GPSCheck.current_Lat<=37.547 && GPSCheck.current_Long>= 126.95 && GPSCheck.current_Long<=126.97
            }
            if (rq.right_num == 4)//이봉창의사동상
            {
                flower_5.gameObject.SetActive(true);
                spotNum = 4;

                //GPSCheck.current_Lat >= 37.5445 && GPSCheck.current_Lat < 37.5447 && GPSCheck.current_Long >= 126.959 && GPSCheck.current_Long < 126.961


                //gps.lat >= 37.5445 && gps.lat <= 37.5447 && gps.lon >= 126.9606 && gps.lon <= 126.9608
            }
            if (wrong == 1)//임정요인
            {
                Debug.Log("Here?2");
                flower_6.gameObject.SetActive(true);
                spotNum = 5;

                //GPSCheck.current_Lat >= 37.5441 && GPSCheck.current_Lat < 37.5443 && GPSCheck.current_Long >= 126.9625 && GPSCheck.current_Long < 126.963


                //gps.lat >= 37.5441 && gps.lat <= 37.5443 && gps.lon >= 126.9627 && gps.lon <= 126.9629
            }
            if (wrong == 2)//효공정문
            {
                flower_7.gameObject.SetActive(true);
                spotNum = 6;

                //GPSCheck.current_Lat >= 37.5442 && GPSCheck.current_Lat < 37.5444 && GPSCheck.current_Long >= 126.961 && GPSCheck.current_Long < 126.9625


                //gps.lat >= 37.5442 && gps.lat <= 37.5444 && gps.lon >= 126.9620 && gps.lon <= 126.9622
            }

        }
        
        switch (spotNum)//한 장소에서 3번 틀린 경우spotNum
        {
            case 0:
                if (rq.countWrong[spotNum]== 2) { 
                    Destroy(flower_1);
                    wrong++;
                    rq.countWrong[spotNum]++;
                }
                else
                {
                    guidec.gameObject.SetActive(true);
                    flowerGuide.gameObject.SetActive(true);
                    moveGuide.gameObject.SetActive(false);
                }
                if (rq.getff)
                    Destroy(flower_1);
                break;
            case 1:
                Debug.Log("spotNum = 1?");
                if (rq.countWrong[spotNum] == 2) { 
                    Destroy(flower_2);
                    wrong++;
                    rq.countWrong[spotNum]++;
                }
                else
                {
                    guidec.gameObject.SetActive(true);
                    flowerGuide.gameObject.SetActive(true);
                    moveGuide.gameObject.SetActive(false);
                }
                if (rq.getff)
                    Destroy(flower_2);
                break;
            case 2:
                if (rq.countWrong[spotNum] == 2)
                {
                    Destroy(flower_3);
                    wrong++;
                    rq.countWrong[spotNum]++;
                }
                else
                {
                    guidec.gameObject.SetActive(true);
                    flowerGuide.gameObject.SetActive(true);
                    moveGuide.gameObject.SetActive(false);
                }
                if (rq.getff)
                    Destroy(flower_3);
                break;
            case 3:
                if (rq.countWrong[spotNum] == 2) {
                    Destroy(flower_4);
                    wrong++;
                    rq.countWrong[spotNum]++;
                }
                else
                {
                    guidec.gameObject.SetActive(true);
                    flowerGuide.gameObject.SetActive(true);
                    moveGuide.gameObject.SetActive(false);
                }

                if (rq.getff)
                    Destroy(flower_4);
                break;
            case 4:
                if (rq.countWrong[spotNum] == 2) {
                    Destroy(flower_5);
                    wrong++;
                    rq.countWrong[spotNum]++;
                }
                else
                {
                    guidec.gameObject.SetActive(true);
                    flowerGuide.gameObject.SetActive(true);
                    moveGuide.gameObject.SetActive(false);
                }

                if (rq.getff)
                    Destroy(flower_5);
                break;
            case 5:
                if (rq.countWrong[spotNum] == 2) {
                    Destroy(flower_6);
                    wrong++;
                    rq.countWrong[spotNum]++;
                }
                else
                {
                    guidec.gameObject.SetActive(true);
                    flowerGuide.gameObject.SetActive(true);
                    moveGuide.gameObject.SetActive(false);
                }

                if (rq.getff)
                    Destroy(flower_6);
                break;
            case 6:
                if (rq.countWrong[spotNum] == 2) {
                    Destroy(flower_7);
                    wrong++;
                    rq.countWrong[spotNum]++;
                }
                else
                {
                    guidec.gameObject.SetActive(true);
                    flowerGuide.gameObject.SetActive(true);
                    moveGuide.gameObject.SetActive(false);
                }

                if (rq.getff)
                    Destroy(flower_7);
                break;
        }
       
        if (rq.right_num ==5)
        {
            if (bgmplay)
            {
            completesound.GetComponent<AudioSource>().Play();
                bgmplay = false;
            }

           
            Destroy(flower_1);
            Destroy(flower_2);
            Destroy(flower_3);
            Destroy(flower_4);
            Destroy(flower_5);
            Destroy(flower_6);
            Destroy(flower_7);
            guidec.gameObject.SetActive(true);
            flowerflag.gameObject.SetActive(true);  //모든 꽃 획득 이미지
            moveGuide.gameObject.SetActive(true);
            flowerGuide.gameObject.SetActive(false);
            if (gc.current_Lat >=0) {//상징조형물
                //GPSCheck.current_Lat >= 37.5447 && GPSCheck.current_Lat < 37.5449 && GPSCheck.current_Long >= 126.961 && GPSCheck.current_Long < 126.963
                Application.LoadLevel(NextSceneString);
            }
        }





            

    }
}
