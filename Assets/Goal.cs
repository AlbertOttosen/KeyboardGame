using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject pointParticle;
    public LifeAndPoints lifeAndPoints;

    void OnTriggerEnter2D(Collider2D other) {
        GameObject obj = other.gameObject;
        if (obj.tag == "Foe") {
            lifeAndPoints.TakeDamage();
            Destroy(obj, 2.0f);
        } else if (obj.tag == "Friend") {
            lifeAndPoints.GetPoint();
            GameObject particle = Instantiate(pointParticle, obj.transform.position, Quaternion.identity);
            Destroy(particle, 1.0f);
            Destroy(obj, 2.0f);
        }
    }
}
