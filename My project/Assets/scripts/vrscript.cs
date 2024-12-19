using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrscript : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  /*  void public first()
    {

    }
    void public second()
    {

    }*/
    void  third()
    {
        a = Random.Range(0, 255);
        b = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color() = new Color32((byte)a, (byte)b, (byte)c, 1);
    }
}
