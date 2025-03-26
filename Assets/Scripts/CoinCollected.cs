using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollected : MonoBehaviour
{
    public int coinCollected = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if (collision.CompareTag("Coin"))
        {
            
            coinCollected++;
            Debug.Log("Coins collected: " + coinCollected);
            Destroy(collision.gameObject);
        }
    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
