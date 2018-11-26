using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class IntroBefore : MonoBehaviour, IPointerClickHandler
{
    public IntroDialog id;

    public void OnPointerClick(PointerEventData eventData)
    {
        id.page--;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
