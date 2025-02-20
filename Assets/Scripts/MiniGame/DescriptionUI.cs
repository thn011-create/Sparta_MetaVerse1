using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DescriptionUI : BaseUI
{
    [SerializeField] private Button closeButton;

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
        closeButton.onClick.AddListener(OnClickCloseButton);
    }
    
    public void OnClickCloseButton()
    {
        uiManager.SetHome();
    }

    protected override UIState GetUIState()
    {
        return UIState.Description;
    }
}
