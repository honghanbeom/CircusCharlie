using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFire : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            PlayerController pc = GameObject.Find("playerLife").GetComponent<PlayerController>();
            pc.playerLife =- 1;
            Debug.LogFormat("라이프 감소, 남은 라이프 {0}", pc.playerLife);
        }
    }
}
