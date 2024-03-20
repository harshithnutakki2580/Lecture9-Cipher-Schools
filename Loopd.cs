using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        do
        {
            Debug.Log("i is : " + i);
            i++;
        }
        while (i <= 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
