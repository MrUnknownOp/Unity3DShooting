using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
            public GameObject bullet;
            public float upwardforce,forwardforce;

            public Transform attackpoint;

            void Update()
            {
                if(Input.GetButtonDown("Fire1"))
                {
                     shoot();
                }
               
            }

            void shoot()
            {
                GameObject currentBullet = Instantiate(bullet , attackpoint.transform.position , Quaternion.identity);

                currentBullet.GetComponent<Rigidbody>().AddForce(attackpoint.transform.forward * forwardforce , ForceMode.Impulse);
                currentBullet.GetComponent<Rigidbody>().AddForce(currentBullet.transform.up * upwardforce , ForceMode.Impulse);
            }
}
