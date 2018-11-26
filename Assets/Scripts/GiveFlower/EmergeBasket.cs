using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmergeBasket : MonoBehaviour {

    public Canvas bc; //basket canvas
    public BloomFlowerFlag bff;
    public RawImage Basket;
    public RawImage Guide;//광주리에 있는 꽃잎들을 끌어 꽃을 피우시오.
    float delta = 0.3f;
    public AudioSource basketSound;
    bool playsound = true;
	// Use this for initialization
	void Start () {
        bc.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		RectTransform basket = Basket.GetComponent<RectTransform>();

        if (bff.is_select)
        {
            if (playsound)
            {
                basketSound.GetComponent<AudioSource>().Play();
                playsound = false;
            }
            bc.gameObject.SetActive(true);
            Destroy(Guide, 1.5f);
        }
	}
}
