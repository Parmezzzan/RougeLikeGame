using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemy;

    public Sprite spriteImage;


    // Start is called before the first frame update
    void Start()
    {
        spriteImage = enemy.sprite;
    }
}
