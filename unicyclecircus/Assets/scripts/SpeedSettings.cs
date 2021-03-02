using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/SpeedSettings")]
public class SpeedSettings : ScriptableObject
{
    [SerializeField] private float _speed;
    public float Speed { get { return _speed; } }
    
}
