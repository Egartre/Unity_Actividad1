using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    public float multiplicar = 0f;
    public float por = 0f;
    public float da;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Resultado: " + this.multiplicar * this.por);
        this.da = this.multiplicar * this.por;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
