using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
   public float Lifetime;

    // Update is called once per frame
    void Update()
    {
        Lifetime -= Time.deltaTime;

        if(Lifetime <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
