using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetection : MonoBehaviour {

    private Dictionary<GameObject, bool> objectsInContact = new Dictionary<GameObject, bool>();

    private bool anyExit = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (anyExit && objectsInContact.Count == 0)
        {
            print("Victory");
            this.enabled = false;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (!objectsInContact.ContainsKey(other.gameObject))
        {
            objectsInContact.Add(other.gameObject, true);
        }
        else
        {
            Debug.LogWarning("Attempted to add game object " + other.gameObject.name + " but object was already present in contact list");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (objectsInContact.ContainsKey(other.gameObject))
        {
            objectsInContact.Remove(other.gameObject);
            anyExit = true;
        }
        else
        {
            Debug.LogWarning("Attempted to remove object " + other.gameObject.name + " but object was not present in contact list");
        }
    }


}
