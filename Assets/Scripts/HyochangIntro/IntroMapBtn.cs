﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class IntroMapBtn : MonoBehaviour, IPointerClickHandler
{
    public Canvas mc;//Map Canvas

    public void OnPointerClick(PointerEventData eventData)
    {
        mc.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
