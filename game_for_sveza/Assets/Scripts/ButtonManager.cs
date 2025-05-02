using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button[] stageButtons;
    public BuildingManager buildingManager;

    void Start()
    {
        for (int i = 0; i < stageButtons.Length; i++)
        {
            int index = i; // Локальная копия для замыкания в лямбде
            stageButtons[i].onClick.AddListener(() => OnStageButtonClicked(index));
        }
    }

    void OnStageButtonClicked(int index)
    {
        if (stageButtons[index].tag == "B5")
            Debug.Log(buildingManager.buildings[index]);
        Debug.Log(buildingManager.buildings[index].price);
        //buildingManager.ActivateBuilding(index); такого метода больше нет, есть ChangeStatus
    }
}
