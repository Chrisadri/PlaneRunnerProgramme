using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -20 * Time.deltaTime);//moving the buildings at a pace of -20z
        Destroy(gameObject, 10);//destroys gameObject (buildings) after 10 seconds
    }
}
