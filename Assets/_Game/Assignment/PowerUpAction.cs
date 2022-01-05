using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DefaultNamespace.ScriptableEvents;
using Variables;

public class PowerUpAction : MonoBehaviour
{
    public PowerUp powerUp;
    [SerializeField] private IntObservable _powerUpObservable;

    private void OnTriggerEnter2D(Collider2D coll) 
    {
        if (string.Equals(coll.gameObject.tag, "Player"))
        {
            Debug.Log("Picked up " + powerUp.name);
            _powerUpObservable.ApplyChange(2);//powerUp.value);
        }
        
    }

}
