using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    protected float velocidadX = 2;
    protected float velocidadY = 0;
    protected bool bajando = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime,
            velocidadY * Time.deltaTime, 0);
        if (transform.position.x > 4 || transform.position.x < -4)
        {
            bajando = true;
            velocidadX = -velocidadX;
            if (bajando)
                velocidadY--;
        }
        if (velocidadY != 0 && !bajando)
            velocidadY = 0;
        if (bajando)
            bajando = false;
    }
}
