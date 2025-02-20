using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;

public class GameUI : BaseUI
{
   
    protected override UIState GetUIState()
    {
        return UIState.Game;
    }
}
