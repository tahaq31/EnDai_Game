using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isHit : MonoBehaviour
{
    private bool hurt=false;
    public bool readDamage=false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hurt= true;
    }

    public bool getHurt()
    {
        readDamage=true;
        return this.hurt;
    }
    public void Update()
    {
        if (readDamage)
        {
           this.hurt = false;
            readDamage = false;

        }
    }
}
