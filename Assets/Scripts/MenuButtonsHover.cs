using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MenuButtonsHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void OnPointerExit(PointerEventData eventData) 
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
