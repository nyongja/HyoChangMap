using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoveBtn : MonoBehaviour, IPointerClickHandler
{
    public RandomQuiz rq;
    public Touch_Flower tf;
    public void OnPointerClick(PointerEventData eventData)
    {
        rq.rcv.gameObject.SetActive(false);
        tf.is_touch = false;//꽃 다시 선택할 수 있도록..!
        rq.dc.gameObject.SetActive(false);
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
