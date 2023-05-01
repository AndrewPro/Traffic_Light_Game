using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounbds : MonoBehaviour
{
    private float topBounds = 78.82f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
    }
}
