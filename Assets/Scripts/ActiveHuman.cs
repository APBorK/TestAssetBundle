using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ActiveHuman : MonoBehaviour
{
    public static ActiveHuman instance;

    [SerializeField] private Transform _transformFinish, _transformStart;

    [SerializeField] private Image _clothe, _hair, _emotion;
    // Start is called before the first frame update

    private void OnEnable()
    {
        MoveHuman();
    }

    void Start()
    {
        instance = this;
        transform.position = _transformStart.position;
    }

    public void MoveHuman()
    {
        transform.DOMove(_transformFinish.position,1);
    }

    public void ExitHuman(Sprite sprite, string name)
    {
        var dot = DOTween.Sequence();
        dot.Append(transform.DOMove(_transformStart.position, 1)).AppendCallback((() => NextSprite(sprite,name)));
    }

    private void NextSprite(Sprite sprite, string name)
    {
        switch (name)
        {
            case "emotions":
                _emotion.gameObject.SetActive(true);
                _emotion.sprite = sprite;
                break;
            case "hair":
                _hair.gameObject.SetActive(true);
                _hair.sprite = sprite;
                break;
            case "Сlothes":
                _clothe.gameObject.SetActive(true);
                _clothe.sprite = sprite;
                break;
        }
        MoveHuman();
    }
}
