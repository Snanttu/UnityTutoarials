using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_by_contact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    private GameObject gameController;
    private GameController otherScript;

    void Start ()
    {
        gameController = GameObject.Find("GameController");
        otherScript = (GameController)gameController.GetComponent(typeof(GameController));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }        
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        otherScript.addScore();
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
