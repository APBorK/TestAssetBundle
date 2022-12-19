using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewContent : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;
    private RectTransform _endrectTransform;
    private bool _start;

    private async void Start()
    {
        await Task.Delay(500);
        _endrectTransform =
            GetComponentsInChildren<RectTransform>()[GetComponentsInChildren<RectTransform>().Length - 1];
        _start = true;
    }

    void Update()
    {
        if (_start)
        {
            if (_rectTransform.anchoredPosition.x > 0)
            {
                _rectTransform.anchoredPosition = new Vector2(0, _rectTransform.anchoredPosition.y);
            }

            if (_rectTransform.anchoredPosition.x < -_endrectTransform.anchoredPosition.x)
            {
                _rectTransform.anchoredPosition = new Vector2(-_endrectTransform.anchoredPosition.x, _rectTransform.anchoredPosition.y);
            } 
        }
    }
}
