using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.EventSystems;

public class Json : MonoBehaviour
{
    public string json;
    public Text hlt;
    public Slider sld;
    public Text name;
    public JsonClass jsndata;
    // Start is called before the first frame update
    void Start()
    {
        sld.interactable = false;
        StartCoroutine(getData());
    }
    IEnumerator getData()
    {
        Debug.Log("Загрузка...");
        var uwr = new UnityWebRequest(json);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var resultFile = Path.Combine(Application.persistentDataPath, "result.json");
        var dh = new DownloadHandlerFile(resultFile);
        dh.removeFileOnAbort  = true;
        uwr.downloadHandler = dh;
        yield return uwr.SendWebRequest();
        if (uwr.result != UnityWebRequest.Result.Success)
        {
            name.text = "Ошибка";
        }
        else
        {
            Debug.Log("Файл сохранен по пути:" + resultFile);
            jsndata = JsonUtility.FromJson<JsonClass>(File.ReadAllText(Application.persistentDataPath + "/result.json"));
            name.text = jsndata.Name.ToString();
            hlt.text = jsndata.Health.ToString();
            sld.value = jsndata.Health;

            yield return StartCoroutine(getData());
        }
    }
    [System.Serializable]
    public class JsonClass
    {
        public string Name;
        public int Health;
    }
    // Update is called once per frame
   
}
