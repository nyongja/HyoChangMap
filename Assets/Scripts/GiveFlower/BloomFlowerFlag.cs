using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloomFlowerFlag : MonoBehaviour {

    public bool is_select = false; //독립운동가가 선택되었는지
    public GameObject tree;
    public Canvas sc;       //Select Canvas

    public GameObject ff;//flowerflag object
    public Canvas bc; //Basket Canvas
    public int flowerCount = 0;   //5개 꽃 다 드래그 되었는지 확인

    public bool bloom = false;

    public TombstoneDialog td;

    int count = 0;
    //꽃피우기
    public GameObject[] flower;
    public GameObject[] flag;
    float time = 0f;

    // Use this for initialization
    void Start () {
        tree.gameObject.SetActive(false);

        //꽃피우기
        flower = GameObject.FindGameObjectsWithTag("Flower");
        flag = GameObject.FindGameObjectsWithTag("Flag");

        for (int i = 0; i < flower.Length; i++)
        {
            flower[i].gameObject.SetActive(false);
            flag[i].gameObject.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
        if (is_select)  //나무자라기
        {
            tree.gameObject.SetActive(true);
            
            Destroy(sc, 0f);
        }

        if (flowerCount >= 5)//꽃피우기
        {
           Destroy(bc, 0.5f);
          
            if (count < 16)
            {
                time += Time.deltaTime;
                while (time > 0.1f)
                {
                    flower[count].gameObject.SetActive(true);
                    flag[count].gameObject.SetActive(true);
                    count++;
                    time = 0;
                }
                
                bloom = true;
                
            }
            
        }



	}
}
