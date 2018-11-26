using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BIsNext : MonoBehaviour, IPointerClickHandler
{
    public string NextSceneString;

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.LoadLevel(NextSceneString);
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
