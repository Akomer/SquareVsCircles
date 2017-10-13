using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    protected float speed;
    protected float lifeTime;
    public Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Debug.Log("Bullet Start");
        Invoke(nameof(SelfDestroy), lifeTime);
    }

    public void ShootOut(Vector3 direction)
    {
        transform.rotation = Quaternion.Euler(direction);
        Debug.Log($"{speed}");
        Debug.Log($"{transform.forward}");
        body.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
    }

    private void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
