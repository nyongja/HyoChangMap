using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckRightAnswer : MonoBehaviour, IPointerClickHandler
{
    public RandomQuiz rq;

    public void OnPointerClick(PointerEventData eventData)
    {
        rq.checkAnswer = true;
        rq.respond = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
