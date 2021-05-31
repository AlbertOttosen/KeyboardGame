using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    public GameObject fire;
    public LifeAndPoints lifeAndPoints;
    public GameObject pointParticle;
    public GameObject losePointParticle;
    public float rangeX;
    public float rangeY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 offset = new Vector3(Random.Range(-1.0f,1.0f)*rangeX,Random.Range(-1.0f,1.0f)*rangeY,0);
        GameObject newFire = Instantiate(fire, transform.position + offset, Quaternion.identity);
        Destroy(newFire, 0.5f);
    }

    void OnTriggerEnter2D(Collider2D other) {
        GameObject obj = other.gameObject;
        if (obj.tag == "Foe") {
            lifeAndPoints.GetPoint();
            GameObject particle = Instantiate(pointParticle, obj.transform.position, Quaternion.identity);
            Destroy(particle, 1.0f);
            Destroy(obj, 2.0f);
        } else if (obj.tag == "Friend") {
            lifeAndPoints.LosePoint();
            GameObject particle = Instantiate(losePointParticle, obj.transform.position, Quaternion.identity);
            Destroy(particle, 1.0f);
            Destroy(obj, 2.0f);
        }
    }
}
