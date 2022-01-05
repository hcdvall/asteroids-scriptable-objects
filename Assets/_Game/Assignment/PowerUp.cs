using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables;

[CreateAssetMenu(fileName = "new PowerUp", menuName = "ScriptableObjects/PowerUp")]
public class PowerUp : ScriptableObject 
{
    [SerializeField] private string name;
    [SerializeField] private float value;
    
}
