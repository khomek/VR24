using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symph : MonoBehaviour
{

    public GameObject svet;
    public Transform obj;
    public float speed = 5.0f;
    public float rotspeed = 10.0f;
    public int y = 0;
    // Start is called before the first frame update
    void Start()
    {
        svet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        y++;
        if (y >= 600)
        {
            if (obj != null)
            {
                svet.SetActive(true);
                obj.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
                obj.Rotate(new Vector3(0, 5, 0) * rotspeed * Time.deltaTime);
                float posY = obj.position.y;
                if (obj.position.y > 16)
                    Destroy(obj.gameObject);

            }
            else
                Destroy(svet);
        }

    }
}
