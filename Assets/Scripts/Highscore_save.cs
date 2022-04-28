using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore_save : MonoBehaviour
{
    public Timemanager  TM;
  public void OnDestroy(){
    {
    TM.stopandsave();
  }
}
}
