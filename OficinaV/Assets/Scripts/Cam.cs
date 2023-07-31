using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform Player;
    public float SuaveMovimentacao;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Player.position.x >= 0)
        {
            Vector3 following = new Vector3(Player.position.x, Player.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, following, SuaveMovimentacao * Time.deltaTime);
        }
    }
}