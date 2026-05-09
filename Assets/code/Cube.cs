using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        rotateor = GetComponent<Rotateor>();
    }

    // Update is called once per frame
    void Update()
    {
        rotateor.Rotate(0, 1, 0);

        
    }
}
