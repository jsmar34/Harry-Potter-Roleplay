﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{

    public float destroyTime;

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, destroyTime);
    }
}
