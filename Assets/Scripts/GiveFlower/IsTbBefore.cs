using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class IsTbBefore : MonoBehaviour, IPointerClickHandler
{
    public TombstoneDialog tb;

    public void OnPointerClick(PointerEventData eventData)
    {
        tb.page--;
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
