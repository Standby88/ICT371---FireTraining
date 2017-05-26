using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public GameObject door;
    public bool goingDown;
    float high;
    float low;

    static float t = 0.0f;
    bool done = true;

    void Start()
    {
        high = 3.930143f;
        low = 1.206551f;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            t = 0.0f;
            done = false;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (!done)
        {
            OpenCloseDoors();
        }
    }

    void OpenCloseDoors()
    {
        door.transform.position = Vector3.Lerp(door.transform.position, new Vector3(door.transform.position.x, low, door.transform.position.z), t);

        t += Time.deltaTime;

        if (t >= 1)
        {
            done = true;
        }
    }
}
