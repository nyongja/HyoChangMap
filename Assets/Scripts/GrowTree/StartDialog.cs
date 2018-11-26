using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDialog: MonoBehaviour {

    public WindBlow wb;
    public Canvas wc;   //windCanvas
    public Canvas dc;   //dialogCanvas
    public string NextSceneString;
    public RawImage before;
    public RawImage next;
    public RawImage map;

    public RawImage dialog1;
    public RawImage dialog2;
    public RawImage dialog3;

    public int page = 0;
    public GameObject tree;
    public Canvas gc;
    float time = 0f;
	// Use this for initialization
	void Start () {
        dc.gameObject.SetActive(false);
        dialog1.gameObject.SetActive(false);
        dialog2.gameObject.SetActive(false);
        dialog3.gameObject.SetActive(false);
        map.gameObject.SetActive(false);
        gc.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {


        if (wb.start_dialog)
        {
            wc.gameObject.SetActive(false);
            dc.gameObject.SetActive(true);

            switch (page)
            {
                case 0:
                    dialog1.gameObject.SetActive(true);
                    dialog2.gameObject.SetActive(false);
                    before.gameObject.SetActive(false);
                    break;
                case 1:
                    dialog1.gameObject.SetActive(false);
                    dialog2.gameObject.SetActive(true);
                    dialog3.gameObject.SetActive(false);
                    before.gameObject.SetActive(true);
                    break;
                case 2:
                    dialog1.gameObject.SetActive(false);
                    dialog2.gameObject.SetActive(false);
                    dialog3.gameObject.SetActive(true);
                    map.gameObject.SetActive(true);
                    break;
                case 3:
                    dc.gameObject.SetActive(false);
                    gc.gameObject.SetActive(true);
                    time += Time.deltaTime;
                    if (time > 1.5f)
                    {
                        Application.LoadLevel(NextSceneString);
                    }
                    break;
            }

        }
	}
}
