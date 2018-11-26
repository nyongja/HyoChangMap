using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalDialog : MonoBehaviour {

    public Drag dg;
    public Canvas gc;
    public Canvas mc;
    public Canvas dc;//Dialog Canvas
    public int page = 0;

    public Canvas pc;//photo Canvas

    public RawImage finishDialog;
    public RawImage before;
    public RawImage next;

    public RawImage take;
    public RawImage pass;

    public RawImage kimgu;
    public RawImage bonggill;
    public RawImage junggeun;
    public RawImage bongchang;
    public RawImage jounggi;

    public RawImage kimDialog1;
    public RawImage kimDialog2;
    public RawImage bongchangDialog1;
    public RawImage bongchangDialog2;
    public RawImage bonggillDialog1;
    public RawImage bonggillDialog2;
    public RawImage bonggillDialog3;
    public RawImage JunggiDialog1;
    public RawImage JunggiDialog2;
    public RawImage JoonggeunDialog1;
    public RawImage JoonggeunDialog2;
    // Use this for initialization
    void Start () {
        dc.gameObject.SetActive(false);
        take.gameObject.SetActive(false);
        pass.gameObject.SetActive(false);

        kimgu.gameObject.SetActive(false);
        bonggill.gameObject.SetActive(false);
        junggeun.gameObject.SetActive(false);
        jounggi.gameObject.SetActive(false);
        bongchang.gameObject.SetActive(false);



        kimDialog1.gameObject.SetActive(false);
        kimDialog2.gameObject.SetActive(false);
        bongchangDialog1.gameObject.SetActive(false);
        bongchangDialog2.gameObject.SetActive(false);
        bonggillDialog1.gameObject.SetActive(false);
        bonggillDialog2.gameObject.SetActive(false);
        bonggillDialog3.gameObject.SetActive(false);
        JunggiDialog1.gameObject.SetActive(false);
        JunggiDialog2.gameObject.SetActive(false);
        JoonggeunDialog1.gameObject.SetActive(false);
        JoonggeunDialog2.gameObject.SetActive(false);
        finishDialog.gameObject.SetActive(false);
        pc.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (!dg.dragging)
        {
            gc.gameObject.SetActive(false);
            mc.gameObject.SetActive(false);
            dc.gameObject.SetActive(true);

            if (page == 0)
            {
                before.gameObject.SetActive(false);
                next.gameObject.SetActive(true);
            }
            if (page == 2)
            {
                pc.gameObject.SetActive(true);
                before.gameObject.SetActive(false);
                next.gameObject.SetActive(false);
                take.gameObject.SetActive(true);
                pass.gameObject.SetActive(true);
                finishDialog.gameObject.SetActive(true);
            }
            switch (SelectChar.charSelect)
            {
                case 1://김구
                    kimgu.gameObject.SetActive(true);
                    
                    if (page == 0) {
                        kimDialog1.gameObject.SetActive(true);
                        kimDialog2.gameObject.SetActive(false);
                        before.gameObject.SetActive(false);
                    }
                       
                   
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        kimDialog2.gameObject.SetActive(true);
                        kimDialog1.gameObject.SetActive(false);
                    }
                    break;
                case 2://윤봉길
                    bonggill.gameObject.SetActive(true);
                    
                    if (page == 0)
                    {
                        bonggillDialog1.gameObject.SetActive(true);
                        bonggillDialog2.gameObject.SetActive(false);
                        before.gameObject.SetActive(false);
                    }
                        
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        bonggillDialog1.gameObject.SetActive(false);
                        bonggillDialog2.gameObject.SetActive(true);
                    }
                    if (page == 2)
                    {
                        bonggillDialog1.gameObject.SetActive(false);
                        bonggillDialog2.gameObject.SetActive(false);
                        bonggillDialog3.gameObject.SetActive(true);
                    }
                    break;
                case 3://이봉창
                    bongchang.gameObject.SetActive(true);
                   
                    if (page == 0)
                    {
                        bongchangDialog1.gameObject.SetActive(true);
                        bongchangDialog2.gameObject.SetActive(false);
                        before.gameObject.SetActive(false);

                    }if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        bongchangDialog1.gameObject.SetActive(false);
                        bongchangDialog2.gameObject.SetActive(true);
                    }
                    break;
                case 4: //안중근
                    bongchang.gameObject.SetActive(true);
                    if (page == 0)
                    {
                        before.gameObject.SetActive(false);
                        JoonggeunDialog1.gameObject.SetActive(true);
                        JoonggeunDialog2.gameObject.SetActive(false);
                    }
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        JoonggeunDialog1.gameObject.SetActive(false);
                        JoonggeunDialog2.gameObject.SetActive(true);
                    }
                    break;
                case 5: //백정기
                    jounggi.gameObject.SetActive(true);
                    if (page == 0)
                    {
                        before.gameObject.SetActive(false);
                        JunggiDialog1.gameObject.SetActive(true);
                        JunggiDialog2.gameObject.SetActive(false);
                    }

                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        JunggiDialog1.gameObject.SetActive(false);
                        JunggiDialog2.gameObject.SetActive(true);
                    }
                    break;
            }
        }
	}
}
