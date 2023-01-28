using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public Prototype enemyTankPrototype;

  [ContextMenu("GetMaket")]

  public void GetMaket(Transform respawn)
  {
    var newUFO = enemyTankPrototype.Instantiate<Prototype>();
    newUFO.transform.position = respawn.position; //оставлю себе для примера
  }
  
}
