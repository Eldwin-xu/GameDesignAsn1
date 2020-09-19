using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float time;
    bool floating;
    // Start is called before the first frame update
    void Start()
    {
        time = 120.0f;
        floating = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 1f, 0f));
        if (time == 120)
        {
            floating = false;
        }

        if (time == 0)
        {
            floating = true;
        }

        if (floating == true)
        {
            time++;
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.02f, transform.position.z);
        }

        if (floating == false)
        {
            time--;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }
}
