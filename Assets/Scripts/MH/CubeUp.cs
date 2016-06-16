﻿using UnityEngine;
using System.Collections;
namespace MH
{
    public class CubeUp : MonoBehaviour
    {
        float delta = 0.1f;
        void OnCollisionEnter(Collision collision)
        {
            Vector3 direction = transform.position - collision.gameObject.transform.position;
            direction = direction.normalized * 300;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float newYposition = transform.localPosition.y + delta;
            transform.localPosition = new Vector3(transform.localPosition.x, newYposition,
                transform.localPosition.z);
            if (transform.localPosition.y < 0.5)
            {
                delta = 0.1f;
            }
            else if (transform.localPosition.y > 5)
            {
                delta = -0.1f;
            }
        }
    }
}


  