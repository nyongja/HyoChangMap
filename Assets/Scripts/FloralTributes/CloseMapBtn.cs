﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CloseMapBtn : MonoBehaviour, IPointerClickHandler
{
    public Canvas mc;

    public void OnPointerClick(PointerEventData eventData)
    {
        mc.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
