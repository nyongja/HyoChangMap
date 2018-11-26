using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TombstoneDialog : MonoBehaviour {
    public Canvas tb; //TombstoneCanvas
    public RawImage nextBtn;
    public RawImage beforeBtn;
    public Canvas gb;//GetBouquet Canvas
    public RawImage getBouquet;

    public BloomFlowerFlag bff;
    public GameObject ff;
    public GameObject tree;

    public RawImage kimguDialog;
    public RawImage bongkillDialog1;
    public RawImage bongkillDialog2;
    public RawImage bongchangDialog1;
    public RawImage bongchangDialog2;
    public RawImage junggeunDialog1;
    public RawImage junggeunDialog2;
    public RawImage junggiDialog1;
    public RawImage junggiDialog2;
    public RawImage kimgu;
    public RawImage bonggill;
    public RawImage bongchang;
    public RawImage junggeun;
    public RawImage junggi;

    public RawImage kbDialog;
    public RawImage bcDialog;
    public RawImage bgDialog;
    public RawImage jgiDialog;
    public RawImage jgnDialog;

    public int page = 0;

    public bool endDialog = false;//비석대화끝\
    //public int charSelect = 0;  //1 : 김구, 2 : 윤봉길 3:이봉창 4: 안중근 5 : 백정기
	// Use this for initialization
	void Start () {
        tb.gameObject.SetActive(false);
        beforeBtn.gameObject.SetActive(false);
        gb.gameObject.SetActive(false);
        kimgu.gameObject.SetActive(false);
        bonggill.gameObject.SetActive(false);
        bongchang.gameObject.SetActive(false);
        junggeun.gameObject.SetActive(false);
        junggi.gameObject.SetActive(false);
        kimguDialog.gameObject.SetActive(false);

        bongkillDialog1.gameObject.SetActive(false);
        bongkillDialog2.gameObject.SetActive(false);
        bongchangDialog1.gameObject.SetActive(false);
        bongchangDialog2.gameObject.SetActive(false);
        junggeunDialog1.gameObject.SetActive(false);
        junggeunDialog2.gameObject.SetActive(false);
        junggiDialog1.gameObject.SetActive(false);
        junggiDialog2.gameObject.SetActive(false);
        kbDialog.gameObject.SetActive(false);
        bcDialog.gameObject.SetActive(false);
        bgDialog.gameObject.SetActive(false);
        jgiDialog.gameObject.SetActive(false);
        jgnDialog.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (bff.bloom)
        {
            tb.gameObject.SetActive(true);
            switch (SelectChar.charSelect)
            {
                case 1:
                    if (page == 0) kimguDialog.gameObject.SetActive(true);
                    if (page == 1)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        kimgu.gameObject.SetActive(true);
                    }
                    break;
                case 2:
                    if (page == 0) {
                        bongkillDialog1.gameObject.SetActive(true);
                        beforeBtn.gameObject.SetActive(false);
                        bongkillDialog2.gameObject.SetActive(false);
                    }
                    else if (page == 1)
                    {
                        bongkillDialog1.gameObject.SetActive(false);
                        beforeBtn.gameObject.SetActive(true);
                        bongkillDialog2.gameObject.SetActive(true);
                    } else if (page == 2)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        bonggill.gameObject.SetActive(true);
                        
                    }

                    break;
                case 3:
                    if (page == 0){
                        bongchangDialog1.gameObject.SetActive(true);
                        bongchangDialog2.gameObject.SetActive(false);
                        beforeBtn.gameObject.SetActive(false);
                    }
                    else if (page == 1)
                    {
                        bongchangDialog1.gameObject.SetActive(false);
                        beforeBtn.gameObject.SetActive(true);
                        bongchangDialog2.gameObject.SetActive(true);
                    }
                    else if (page == 2)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        bongchang.gameObject.SetActive(true);
                        
                    }
                    break;
                case 4:
                    if (page == 0){
                        junggeunDialog1.gameObject.SetActive(true);
                        junggeunDialog2.gameObject.SetActive(false);
                        beforeBtn.gameObject.SetActive(false);
                    }
                    else if (page == 1){
                        beforeBtn.gameObject.SetActive(true);
                        junggeunDialog1.gameObject.SetActive(false);
                        junggeunDialog2.gameObject.SetActive(true);
                    }
                    else if (page == 2){
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        junggeun.gameObject.SetActive(true);
                      
                    }
                    break;
                case 5:
                    if (page == 0){
                        junggiDialog1.gameObject.SetActive(true);
                        junggiDialog2.gameObject.SetActive(false);
                        beforeBtn.gameObject.SetActive(false);
                    }
                    else if (page == 1)
                    {
                        junggiDialog1.gameObject.SetActive(false);
                        beforeBtn.gameObject.SetActive(true);
                        junggiDialog2.gameObject.SetActive(true);
                    }
                    else if (page == 2)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        junggi.gameObject.SetActive(true);
                    }
                    break;
            }
        }

        if (endDialog)
        {
            if (SelectChar.charSelect == 1)
            {
                kbDialog.gameObject.SetActive(true);
             
            }else if (SelectChar.charSelect == 2)
            {
                bgDialog.gameObject.SetActive(true);
            }
            else if (SelectChar.charSelect == 3)
            {
                bcDialog.gameObject.SetActive(true);
            }
            else if (SelectChar.charSelect == 4)
            {
                jgnDialog.gameObject.SetActive(true);
            }
            else if (SelectChar.charSelect == 5)
            {
                jgiDialog.gameObject.SetActive(true);
            }
        }
	}
}
