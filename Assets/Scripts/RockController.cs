using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)     //destroy rock if it hits a set of stairs
    {
        if (other.tag == "Rock")
        {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        }
    }
}
