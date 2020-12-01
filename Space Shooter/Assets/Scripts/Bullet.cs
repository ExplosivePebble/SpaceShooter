using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource explosionSource;
    void Start()
    {
        explosionSource = GetComponent<AudioSource>();
        GetComponent<Rigidbody>().AddForce(transform.up * 350);
    }

    public void KillOldBullet()
    {
        Destroy(gameObject, 2.0f);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        explosionSource.Play();
        Destroy(gameObject, 0.75f);
    }
}