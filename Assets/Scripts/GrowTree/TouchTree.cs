using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchTree : MonoBehaviour {

    public GameObject tree;
    public RawImage wind;
    public bool is_click ;
    public AudioSource windsound;
    bool ws = true;
	// Use this for initialization
	void Start () {
        wind.gameObject.SetActive(false);
        is_click = false;
	}

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Tree")
            {
                if (ws)
                {
                    windsound.GetComponent<AudioSource>().Play();
                    ws = false;
                }
                wind.gameObject.SetActive(true);
                //Destroy(tree);
                is_click = true;

            }
        }
    }
}
