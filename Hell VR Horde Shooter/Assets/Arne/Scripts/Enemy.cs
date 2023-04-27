using UnityEngine;

public class Enemy
{
    public string hit_Tag;

    public int health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;

            if (health <= 0)
                Die();
        }
    }

    private int _health;

    private void Die ()
    {
        Debug.Log("I Died");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == hit_Tag)
        {
            health -= collision.gameObject.GetComponent<Projectile>().damage;

            //Destroy this object
            collision.gameObject.GetComponent<Projectile>().DestroyObject();
        }
    }
}
