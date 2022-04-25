using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelgenerator : MonoBehaviour
{ 
    [SerializeField] private Transform Start;
    [SerializeField] private List<Transform> LevelPartList;


    public Transform player; 

    private Vector3 lastEndPosition;
private void Awake() {
    lastEndPosition = Start.Find("EndPosition").position;
}
private void Update() {
    if(player == null) return;
    
    if(Vector3.Distance(player.position,lastEndPosition) < 50){
        SpawnLevelPart();
    }
}

private void SpawnLevelPart() {
    Transform chosenLevelPart = LevelPartList[Random.Range(0, LevelPartList.Count)];
    Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
    lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
}
private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition){
     Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
     return levelPartTransform;
}

}
