using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickForPict : MonoBehaviour,IPointerClickHandler
{
    [HideInInspector]
    public string Name;

    public void OnPointerClick(PointerEventData eventData)
    {
        ActiveHuman.instance.ExitHuman(GetComponent<Image>().sprite,Name);
    }
}
