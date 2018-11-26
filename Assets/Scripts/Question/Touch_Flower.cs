using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch_Flower : MonoBehaviour {

    public bool is_touch;
    public RandomQuiz rq;
	// Use this for initialization
	void Start () {
        is_touch = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Flower")
                {
                    is_touch = true;
                    rq.qlock = true;
                }
            }
        }
    }
}
