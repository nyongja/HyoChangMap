using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class FlowerFlagMoving : MonoBehaviour, IDragHandler, IEndDragHandler{
    public AudioSource movingSound;
    bool playsound = true;
    public BloomFlowerFlag bff;
    public Canvas bc;//BasketCanvas
    public AudioSource completeSound;
    bool complaysound = true;
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        if (playsound)
        {
            movingSound.GetComponent<AudioSource>().Play();
            playsound = false;
        }
        transform.position = Input.mousePosition;
        bff.flowerCount++;
    }

    public void Update()
    {
        if (bff.flowerCount == 5) {
            if (complaysound)
            {
                completeSound.GetComponent<AudioSource>().Play();
                complaysound = false;
            }
            bc.gameObject.SetActive(false);
            bff.is_select = false;
            
        }
    }

}
