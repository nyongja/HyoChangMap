﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SelectBongChang : MonoBehaviour, IPointerClickHandler
{
    public BloomFlowerFlag bff;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        bff.is_select = true;
        SelectChar.charSelect = 3;
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
