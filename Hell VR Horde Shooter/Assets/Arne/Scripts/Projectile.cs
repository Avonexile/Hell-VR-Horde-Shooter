using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    public float speed;

    public string hit_Tag;

    public void DestroyObject ()
    {
        Destroy(gameObject);
    }
}
