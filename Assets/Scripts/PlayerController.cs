using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    void Start()
    {

    }

    string roed = "u";

    void ifs(ref Quaternion curDir, int rotaNum, ref string roed, string dirVa)
    {
        curDir = Quaternion.Euler(0, rotaNum, 0);
        transform.rotation = curDir;
        roed = dirVa;

    }

    void FixedUpdate()
    {
        Vector3 curPos = transform.position;
        Quaternion curDir = transform.rotation;
        if (curPos.x == 96 && roed == "u")
        {
            if (curPos.z < 107)
            {
                curPos.z += speed * 0.02f;
                transform.position = curPos;
            }
            else
            {
                ifs(ref curDir, -90, ref roed, "l");
            }
        }
        if (curPos.z >= 107 && roed == "l")
        {
            if (curPos.x > -11)
            {
                curPos.x -= speed * 0.02f;
                transform.position = curPos;
            }
            else
            {
                ifs(ref curDir, -180, ref roed, "d");
            }
        }
        if (curPos.x <= -11 && roed == "d")
        {
            if (curPos.z > -11)
            {
                curPos.z -= speed * 0.02f;
                transform.position = curPos;
            }
            else
            {
                ifs(ref curDir, 90, ref roed, "r");
            }
        }
        if (curPos.z <= -11 && roed == "r")
        {
            if (curPos.x < 96)
            {
                curPos.x += speed * 0.02f;
                transform.position = curPos;
            }
            else
            {
                ifs(ref curDir, 0, ref roed, "u");
            }
        }
    }
}
