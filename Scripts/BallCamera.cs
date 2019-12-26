using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamera : MonoBehaviour
{

    public Transform tr;

    public Vector3 posOffset = Vector3.zero;
    public Vector3 angOffcet = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = tr.position + posOffset;
    }
}
