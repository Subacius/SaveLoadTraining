using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SaveLoadSystem;

[RequireComponent(typeof(SaveableEntity))]

public class MainMenu : MonoBehaviour, ISaveable
{
    public int currentCase = 1;
    public Button button;

public void TestButton() {
    Debug.Log(currentCase);
    Debug.Log("Pries Switch");
    switch (currentCase) {
        case 1:
            // Do something for case 1
            currentCase = 2;
            Debug.Log( currentCase);
            Debug.Log("Case 1");
            break;
        case 2:
            // Do something for case 2
            currentCase = 3;
            Debug.Log( currentCase);
            Debug.Log("Case 2");
            break;
        case 3:
            // Do something for case 3
            currentCase = 4;
            Debug.Log( currentCase);
            Debug.Log("Case 3");
            break;
        case 4:
            // Do something for case 4
            currentCase = 5;
            Debug.Log( currentCase);
            Debug.Log("Case 4");
            button.gameObject.SetActive(false);
            break;

        }

    }

    [System.Serializable]
    struct BlockData
    {
        public int currentCase;

        
    }
    
    public object SaveState()
    {
        return new BlockData()
        {
            currentCase = currentCase,

        };
    }
    public void LoadState(object state)
    {
        BlockData data = (BlockData)state;
        currentCase = data.currentCase;

    }

    public bool NeedsToBeSaved()
    {
        return true;
    }
    public bool NeedsReinstantiation()
    {
        return true;
    }

    public void PostInstantiation(object state)
    {
        BlockData data = (BlockData)state;

    }
    public void GotAddedAsChild(GameObject obj, GameObject hisParent)
    {

    }

}
