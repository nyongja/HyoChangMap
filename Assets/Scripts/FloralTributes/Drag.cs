using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Drag : MonoBehaviour, IDragHandler, IEndDragHandler
{

    bool playsound = true;
    public bool dragging = true;

    public AudioSource tributeSound;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (playsound)
        {
            tributeSound.GetComponent<AudioSource>().Play();
            playsound = false;
        }
        transform.position = Input.mousePosition;
        Debug.Log(dragging);
        dragging = false;
    }

    public void Update()
    {
        if (!dragging)
        {
            Destroy(gameObject,0.2f);
        }
    }

}
