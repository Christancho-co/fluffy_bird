using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed, lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }
}
