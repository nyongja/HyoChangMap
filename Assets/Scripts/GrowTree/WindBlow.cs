using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindBlow : MonoBehaviour {
    public TouchTree tt;
    
    private float delta = 12f;

    public bool start_dialog = false;
    public bool is_blow;
	// Use this for initialization
	void Start () {
        is_blow = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (tt.is_click)
        {
            RectTransform rt = GetComponent<RectTransform>();
            rt.position = new Vector3(rt.position.x + delta,
                                    rt.position.y,
                                    rt.position.z);
            if (rt.position.x >= 300)
            {
                delta = -10f;
                is_blow = true;
            }

            if (rt.position.x < -900) start_dialog = true;
                //Application.LoadLevel(NextSceneString);
        }
	}
}
