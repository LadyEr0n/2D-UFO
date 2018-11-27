using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour {

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            //other.gameObject.SetActive(false);
        }


    }
}
