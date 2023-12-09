using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColor : MonoBehaviour
{

    Renderer r;
    [SerializeField]
    Color colorCubo;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        r.material.color = colorCubo;
    }
}
