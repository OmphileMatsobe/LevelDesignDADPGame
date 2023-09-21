using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPotion : MonoBehaviour
{
    GameManager game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        game.potionCount++;
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
