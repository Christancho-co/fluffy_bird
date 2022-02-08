using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;//obstacle1;
    public float timetoswap,inicialtime;
    public Vector3 offsetposition;
    public float Dif;

    void Start()
    {
        GameObject newobstacle = Instantiate(obstacle);
        newobstacle.transform.position = transform.position + new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
      if (inicialtime > timetoswap)
            {
                GameObject newobstacle = Instantiate(obstacle);
             newobstacle.transform.position = transform.position + new Vector3(0, Random.Range(-Dif,Dif), 0);
            inicialtime = 0;
            }
        else
        {
            inicialtime += Time.deltaTime;
        } 
        }
}
