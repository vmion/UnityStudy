using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask wharIsProp;
    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;

    public float maxDamage = 100f;
    public float explosionForce = 100f;
    public float lifeTime = 10f;
    public float explosionRadius = 20f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 
            explosionRadius, wharIsProp);
        for(int i =0; i < colliders.Length; i++)
        {
            Rigidbody targetRigdbody = colliders[i].GetComponent<Rigidbody>();
            targetRigdbody.AddExplosionForce(explosionForce, transform.position,
                explosionRadius);

            Prop targetProp = colliders[i].GetComponent<Prop>();
            float damage = CalculateDamage(colliders[i].transform.position);
            targetProp.TakeDamage(damage);
        }

        explosionParticle.transform.parent = null;

        explosionParticle.Play();
        explosionAudio.Play();

        GameManager.instance.OnBallDestroy();

        Destroy(explosionParticle.gameObject, explosionParticle.duration);
        Destroy(gameObject);
    }
    private float CalculateDamage(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;
        float distance = explosionToTarget.magnitude;
        float edgeToCenterDistance = explosionRadius - distance;
        float percentage = edgeToCenterDistance / explosionRadius;
        float damage = percentage * maxDamage;
        //-값을 통해 체력이 회복되는 것을 막기위해
        damage = Mathf.Max(0, damage);
        return damage;
    }
}
