using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerFlagBlow : MonoBehaviour {
    public WindBlow wb;

    public Flower_Flag ff;
   
    int length;
    float delta = 3f;
    // Use this for initialization
    void Start () {
        


    }


    void FlowerFlagMove()
    {
        for ( int i = 0; i < ff.flower.Length; i++) {
            Transform fr = ff.flower[i].GetComponent<Transform>();
            Transform fl = ff.flag[i].GetComponent<Transform>();
            fr.position = new Vector3(fr.position.x + delta * 0.8f,
                                         fr.position.y + delta * 1.0f,
                                         fr.position.z);

            
            fl.position = new Vector3(fl.position.x + delta * 0.8f,
                                         fl.position.y + delta * 0.9f,
                                         fl.position.z);
        }
        
    }


    // Update is called once per frame
    void Update () {
		if (wb.is_blow){
            FlowerFlagMove();
        }
	}
}
