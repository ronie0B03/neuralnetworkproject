using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    bool increasingSize = false;
    Material mat;
    // Use this for initialization
    void Start()
    {
        //mat = GetComponent<Renderer>().material;
        //mat.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;
        Vector3 angles = transform.eulerAngles;
        angles.z += delta * 50f;
        transform.eulerAngles = angles;
        Vector3 localScale = transform.localScale;
        /*
        Vector3 localScale = transform.localScale;
        if (increasingSize == true)
        {
            localScale += new Vector3(0.04006806f, 0.04006806f, 0f);
            if (localScale.x >= 2f)
            {
                increasingSize = false;
            }
        }
        else if (increasingSize == false)
        {
            localScale -= new Vector3(delta, delta, 0f);
            if (localScale.x <= 1f)
            {
                increasingSize = true;
            }
        }
        */
        transform.localScale = localScale;


    }
}
