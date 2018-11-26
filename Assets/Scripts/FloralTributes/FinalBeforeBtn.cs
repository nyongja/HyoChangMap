using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class FinalBeforeBtn : MonoBehaviour, IPointerClickHandler
{
    public FinalDialog fd;

    public void OnPointerClick(PointerEventData eventData)
    {
        fd.page--;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
