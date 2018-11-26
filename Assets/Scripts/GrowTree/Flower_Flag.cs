using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower_Flag : MonoBehaviour {

    public TouchTree tt;
    public AudioSource growtreesound;
    //int i = 0;
    public GameObject[] flower;
    public GameObject[] flag;
    bool gts = true;

    // Use this for initialization

    int count = 0;

    float time = 0f;
    public RawImage touchtree;
    
	void Start () {
        flower = GameObject.FindGameObjectsWithTag("Flower");
        flag = GameObject.FindGameObjectsWithTag("Flag");

        for ( int i = 0; i < flower.Length; i++)
        {
            flower[i].gameObject.SetActive(false);
            flag[i].gameObject.SetActive(false);
        }

        touchtree.gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

        if (count < 16)
        {
            time += Time.deltaTime;
            while (time > 0.1f)
            {
                if (gts){
                    growtreesound.GetComponent<AudioSource>().Play();
                    gts = false;
                }
                
                flower[count].gameObject.SetActive(true);
                flag[count].gameObject.SetActive(true);
                count++;
                time = 0;

            }
        }
        else
        {
            touchtree.gameObject.SetActive(true);
            Destroy(touchtree, 3f);

        }
    }
}
