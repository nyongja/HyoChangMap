using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour {

    public Canvas sc; //Select Canvas
    public RawImage NextBtn;
    public RawImage BeforeBtn;
    public Canvas dc; //Dialog Canvas
    public RawImage Dialog1;
    public RawImage Dialog2;
    public int page = 0;

	// Use this for initialization
	void Start () {
        sc.gameObject.SetActive(false);
        BeforeBtn.gameObject.SetActive(false);
        Dialog1.gameObject.SetActive(false);
        Dialog2.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
        if (page == 0)
        {
            Dialog2.gameObject.SetActive(false);
            Dialog1.gameObject.SetActive(true);
            BeforeBtn.gameObject.SetActive(false);
        }
        else if (page == 1)
        {
            Dialog1.gameObject.SetActive(false);
            Dialog2.gameObject.SetActive(true);
            BeforeBtn.gameObject.SetActive(true);
        }else if (page == 2)
        {
            dc.gameObject.SetActive(false);
            sc.gameObject.SetActive(true);
        }

	}
}
