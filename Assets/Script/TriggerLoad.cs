using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLoad : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SaveLoad.Load();
            
            //Vector3 a = new Vector3(Game.player.x, Game.player.y, Game.player.z);
            other.gameObject.transform.position = Game.player.loc;
            Debug.Log(other.gameObject.transform.position.x + " " + other.gameObject.transform.position.y + " " + other.gameObject.transform.position.z);
        }
    }
}
