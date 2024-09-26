using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tiktak : MonoBehaviour
{
    public GameObject capsula;
    public GameObject svet;
    public int x = 0;
 
    
    // Start is called before the first frame update
    void Start()
    {
        svet.SetActive(false);
       
    }
    // capsula.GetComponent<Renderer>().material.color = Color.red; //поменяла цвет объекта на крассный

    // Update is called once per frame
    void FixedUpdate()
    {
        x++;
        if (x >= 100)
        {
            svet.SetActive(true);

            if (x>=150 && x<=200)
            {
                capsula.GetComponent<Renderer>().material.color = Color.cyan; //поменяла цвет объекта на крассный
            }
            else {
                capsula.GetComponent<Renderer>().material.color = Color.green;
            }

        }



        if (x > 250)
        {
            capsula.SetActive(false);
            svet.SetActive(false);
         
        }
    }
}
