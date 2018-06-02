﻿using UnityEngine;
using System.Collections;

public class LightFade : MonoBehaviour
{
	void Update ()
    {
        GetComponent<Light>().range = Mathf.Lerp(GetComponent<Light>().range, 0, Time.deltaTime);
	}
}
