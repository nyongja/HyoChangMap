using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class GNextBtn : MonoBehaviour, IPointerClickHandler
{
    public StartDialog sd;

    public void OnPointerClick(PointerEventData eventData)
    {
        sd.page++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
