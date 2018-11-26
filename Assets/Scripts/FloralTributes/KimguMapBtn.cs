using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class KimguMapBtn : MonoBehaviour, IPointerClickHandler
{
    public Canvas mc;
    public RawImage map;
    public RawImage no_map;
    public void OnPointerClick(PointerEventData eventData)
    {
        mc.gameObject.SetActive(true);
        no_map.gameObject.SetActive(false);
        map.gameObject.SetActive(true);
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
