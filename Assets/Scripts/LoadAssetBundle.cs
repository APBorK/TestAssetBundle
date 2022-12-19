using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
  [SerializeField] private List<string> _listPathName;
  [SerializeField] private string _nameOfAssetBundle,_startPath;

  private void Start()
  {
    StartCoroutine(LoadAssetBundles());
  }

  private IEnumerator LoadAssetBundles()
  {
    string platform = "StandaloneWindows";

    string pathToAssetBundle = Path.Combine(Application.streamingAssetsPath, platform);

    var bundleLoadRequest = AssetBundle.LoadFromFileAsync(Path.Combine(pathToAssetBundle,_nameOfAssetBundle));
    yield return bundleLoadRequest;
    var myLoadAssetBundle = bundleLoadRequest.assetBundle;
    var myLoadAssetBundleName = bundleLoadRequest.assetBundle.GetAllAssetNames();
    for (int i = 0; i < myLoadAssetBundleName.Length; i++)
    {
      if (myLoadAssetBundleName[i].StartsWith(_listPathName[0]))
      {
        var nameSprite = myLoadAssetBundleName[i].Remove(0, _listPathName[0].Length);
        var spriteReqest = myLoadAssetBundle.LoadAssetAsync(nameSprite,typeof(Sprite));
        var sprite = spriteReqest.asset as Sprite;
        var typeSprite = myLoadAssetBundleName[i].Remove(0, _startPath.Length);

        Debug.Log(typeSprite);
        Debug.Log(typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length));
        Creation.instante.AddListGameObject(sprite,typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length));
      }

      if (myLoadAssetBundleName[i].StartsWith(_listPathName[1]))
      {
        var nameSprite = myLoadAssetBundleName[i].Remove(0, _listPathName[1].Length);
        var spriteReqest = myLoadAssetBundle.LoadAssetAsync(nameSprite,typeof(Sprite));
        var sprite = spriteReqest.asset as Sprite;
        var typeSprite = myLoadAssetBundleName[i].Remove(0, _startPath.Length);
        typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length);
        Creation.instante.AddListGameObject(sprite,typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length));
      }
        
      if (myLoadAssetBundleName[i].StartsWith(_listPathName[2]))
      {
        var nameSprite = myLoadAssetBundleName[i].Remove(0, _listPathName[2].Length);
        var spriteReqest = myLoadAssetBundle.LoadAssetAsync(nameSprite,typeof(Sprite));
        var sprite = spriteReqest.asset as Sprite;
        var typeSprite = myLoadAssetBundleName[i].Remove(0, _startPath.Length);
        typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length);
        Creation.instante.AddListGameObject(sprite,typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length));
      }
        
      if (myLoadAssetBundleName[i].StartsWith(_listPathName[3]))
      {
        var nameSprite = myLoadAssetBundleName[i].Remove(0, _listPathName[3].Length);
        var spriteReqest = myLoadAssetBundle.LoadAssetAsync(nameSprite,typeof(Sprite));
        var sprite = spriteReqest.asset as Sprite;
        var typeSprite = myLoadAssetBundleName[i].Remove(0, _startPath.Length);
        typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length);
        Creation.instante.AddListGameObject(sprite,typeSprite.Remove(typeSprite.Length - nameSprite.Length,nameSprite.Length));
      }
      //Debug.Log(myLoadAssetBundleName[i].Remove(0,"assets/resources/body/".Length));
    }
    //var spriteReqest = myLoadAssetBundle.LoadAssetAsync("body.png",typeof(Sprite));
    //_image.sprite = spriteReqest.asset as Sprite;
  }
}
