using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionManager : MonoBehaviour
{
   public void OnToTitleButton()
    {
        SoundManager.instance.PlaySE(1);
    }
}
