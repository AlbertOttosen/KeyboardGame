using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeAndPoints : MonoBehaviour
{
    [SerializeField] private List<GameObject> hearts;
    [SerializeField] private Text pointText;
    private int health;
    private int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage() {
        Destroy(hearts[0]);
        hearts.RemoveAt(0);
        health--;
    }

    public void GetPoint() {
        points++;
        pointText.text = "Points: "+points.ToString();
    }

    public void LosePoint() {
        points++;
        pointText.text = "Points: "+points.ToString();
    }
}
