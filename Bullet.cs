using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
   public float Lifetime;
   public float damage;

    // Update is called once per frame
    void Update()
    {
        Lifetime -= Time.deltaTime;

        if(Lifetime <= 0f)
        {
            Destroy(this.gameObject);
        }
    }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.CompareTag("Enemy"))
            {
                
            /*Your enemy logic here*/
                Enemy enemy = collision.collider.GetComponent<Enemy>();
                enemy.TakeDamage(damage);
                 
            /* Your enemy logic till here*/
                 DestroyBullet();
            }

            
            
            
        }

        private void DestroyBullet()
        {
            Destroy(gameObject);
            return;
        }
    
}
