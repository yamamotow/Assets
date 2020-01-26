using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject[] spheres;
    public Material[] materials;
    float interval;
    //Vector2 rb_Pos, rs_Pos, bb_Pos, bs_Pos;

    // Use this for initialization
    void Start()
    {
        //生成間隔の設定
        interval = Random.Range(4f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > interval)
        {
            int rand = Random.Range(1, 3);
            float y = Random.Range(-6f, 6f);
            for (int i = 0; i < 3; i++){
                Instantiate(spheres[(rand + i) % 3], new Vector3(-5 + i * 5, 1, y), Quaternion.identity);
            }
            interval += Random.Range(4f, 6f);
        }
    }
}