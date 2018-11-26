using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountRightNum : MonoBehaviour {
    public Text countNum;
    public RandomQuiz rq;
    public GPSCheck gps;
    public RawImage allflowerflag;
    float time = 0f;
    public Canvas gc;
	// Use this for initialization
	void Start () {
        //나중에 게임 시작 시 숫자 나타나도록 수정할 것..
        //  countNum.gameObject.SetActive(false);
     
    }

    // Update is called once per frame
    void Update() {

        Text cn = countNum.GetComponent<Text>();
     
        switch (rq.right_num)
        {
            case 0:
                cn.text = "( 0 / 5 )";
                break;
            case 1:
                cn.text = "( 1 / 5 )";
                
                break;
            case 2:
                cn.text = "( 2 / 5 )";
                
               
                break;
            case 3:
                cn.text = "( 3 / 5 )";
                
                break;
            case 4:
                cn.text = "( 4 / 5 )";
                break;
            case 5:
                cn.text = "( 5 / 5 )";
                if (time < 1.5f)
                {
                    gc.gameObject.SetActive(true);
                    allflowerflag.gameObject.SetActive(true);
                    time += Time.deltaTime;
                }
                break;
            case 6:
                break;
        }
    }
}
