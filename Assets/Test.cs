using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start ()
    {
        int[] points = { 0, 1, 2, 3, 4 };
        
        for (int i = 0; i  <= 4;  i++)
        {
            Debug.Log(points [i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    }
     void Update  ()
    {

    }
}