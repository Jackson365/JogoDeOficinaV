using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemHeart : MonoBehaviour
{
    public int valueHaelth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().IncreaseLife(valueHaelth);
            Destroy(gameObject);
        }
    }
}