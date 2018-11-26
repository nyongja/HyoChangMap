using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFlower : MonoBehaviour {
    public bool is_emerge = false;

    public Drag dg;
    public GameObject Flower;
	// Use this for initialization
	void Start () {
        Flower.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (is_emerge && dg.dragging)
        {
            Flower.gameObject.SetActive(true);
        }
	}
}
