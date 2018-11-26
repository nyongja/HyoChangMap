using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class IsNext : MonoBehaviour, IPointerClickHandler
{
    public Dialog dg;

    public void OnPointerClick(PointerEventData eventData)
    {
        dg.page++;
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
