using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creation : MonoBehaviour
{
    public static Creation instante;

    [SerializeField] private List<string> _listPathName;
    [SerializeField] private Image _bodySprite,_prefabs;
    [SerializeField] private GameObject _human,_hairCont,_clotheCont,_emotionCont;
    private List<Sprite> _body = new List<Sprite>(), _emotions = new List<Sprite>(), _hair = new List<Sprite>(), _clothes = new List<Sprite>();
    private int _hairId, _clotheId, _emotionId;
    void Start()
    {
        instante = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddListGameObject(Sprite sprite,string namePath)
    {
        if (namePath.StartsWith(_listPathName[0]))
        {
            _human.SetActive(true);
            _bodySprite.sprite = sprite;
            _bodySprite.SetNativeSize();
            _body.Add(sprite);
        }

        if (namePath.StartsWith(_listPathName[1]))
        {
            _prefabs.sprite = sprite;
            _prefabs.GetComponent<ClickForPict>().Name = _listPathName[1]; 
            CreateObject(_emotionCont.transform,_prefabs.gameObject,_emotionId,1f);
            _emotions.Add(sprite);
            _emotionId++;
        }
        
        if (namePath.StartsWith(_listPathName[2]))
        {
            _prefabs.sprite = sprite;
            _prefabs.GetComponent<ClickForPict>().Name = _listPathName[2]; 
            CreateObject(_hairCont.transform,_prefabs.gameObject,_hairId,1f);
            _hair.Add(sprite);
            _hairId++;
        }
        
        if (namePath.StartsWith(_listPathName[3]))
        {
            _prefabs.sprite = sprite;
            _prefabs.GetComponent<ClickForPict>().Name = _listPathName[3]; 
            CreateObject(_clotheCont.transform,_prefabs.gameObject,_clotheId,0);
            _clothes.Add(sprite);
            _clotheId++;
            _clotheId++;
        }
    }

    public void CreateObject(Transform transform,GameObject gameObject,int id, float offset)
    {
        var game = Instantiate(gameObject, transform);
        game.transform.position = new Vector3(game.transform.position.x + id,game.transform.position.y - offset,game.transform.position.z);
    }
}
