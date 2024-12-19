using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class script : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    public GameObject Cil;
    public GameObject Cap;
    public int a;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void first()
    {
        a = 3;
       Cil.transform.position = new Vector3(a, 1, 5);
    }
    public void second()
    {
        a = 0;
        Cil.transform.position = new Vector3(a, 1, 5);
    }
    public void nul()
    {
        x = Random.Range(0, 255);
        y = Random.Range(0, 255);
        z = Random.Range(0, 255);
       Cap.GetComponent<Renderer>().material.color = new Color32((byte)x, (byte)y, (byte)z, 1);

    }
}
