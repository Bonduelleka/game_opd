using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] buildingObjects;
    public Building[] buildings;


    private void Awake()
    {
        buildings = new Building[buildingObjects.Length];

        for (int i = 0; i < buildingObjects.Length; i++)
        {
            buildings[i] = buildingObjects[i].GetComponent<Building>();

            if (buildings[i] == null)
            {
                Debug.LogError($"�� ������� {buildingObjects[i].name} ��� ���������� Building!");
            }
        }
        //Debug.Log(buildings[4].price);
    }



    public void ActivateBuilding(int index)
    {
        //if (index < 0 || index >= buildings.Length)
        //{
        //    Debug.LogWarning("������ ��� ���������: " + index);
        //    return;
        //}

        // �������� ������ ������
        //buildings[index].SetActive(true);

        // (�����������) ��������� ��� ��������� ������, ���� �����
        //for (int i = 0; i < buildings.Length; i++)
        //{
        //    if (i != index)
        //        buildings[i].SetActive(false);
        //}

        Debug.Log($"������������ ������: {index}");
    }
}
