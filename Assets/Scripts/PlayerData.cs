using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData" ,menuName ="Players/Player data")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public GameObject playerPrefab;
    [Range(1, 900)]
    public int weight;
    [Range(1, 200)]
    public int strength;
    public string breath;
    public bool flight;
    [Range(1,50)]
    public int damage;
    [Range(1, 80)]
    public int speed;
}
