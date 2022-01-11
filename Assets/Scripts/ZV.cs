using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZV : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
