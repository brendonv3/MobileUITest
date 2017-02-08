using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	void Start () {
        LoadJson();
	}
	
	void Update () {
		
	}

    public void LoadJson()
    {
        string path = System.IO.Path.Combine("JsonData/Maps", "test_map");
        TextAsset asset = Resources.Load(path) as TextAsset;
        SerialisedMap map = JsonUtility.FromJson<SerialisedMap>(asset.text);
        Debug.Log(":p");
        Debug.Log(JsonUtility.ToJson(map));
    }
}
