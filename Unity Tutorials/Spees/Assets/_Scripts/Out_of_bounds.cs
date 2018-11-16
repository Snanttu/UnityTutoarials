using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out_of_bounds : MonoBehaviour {

	void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
