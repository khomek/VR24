using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public int x = 0;
    private int y = 0;
    public GameObject capsula;
    // Start is called before the first frame update
    void Start()
    {
        
        //capsula.GetComponent<Renderer>().material.color = Color.magenta;
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        if(x >= 600 && capsula != null)
        {
            if ((x > 650 && x < 850) || (x > 1050 && x < 1250) || (x > 1550 && x<1750) || (x>1950))
                y = 1;
            if ((x >= 850 && x <= 1050) || (x >= 1250 && x <= 1550) || (x>=1750 && x<=1950))
                y = 2;

                switch (y)
            {
                case 1: capsula.GetComponent<Renderer>().material.color = Color.cyan;
                    break;
                case 2: capsula.GetComponent<Renderer>().material.color = Color.green;
                    break;
            }
  
            
        }



        
    }
}
        
