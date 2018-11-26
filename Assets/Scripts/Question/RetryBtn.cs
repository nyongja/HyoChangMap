using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RetryBtn : MonoBehaviour, IPointerClickHandler
{
    public RandomQuiz rq;

    public void OnPointerClick(PointerEventData eventData)
    {
        rq.qlock = true;
        rq.dc.gameObject.SetActive(false);
        rq.rcv.gameObject.SetActive(false);
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
