using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{
    public static int ponits = 0;
    // Start is called before the first frame update
    void Start()
    {
        ponits = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = ponits.ToString();
       
    }
}
