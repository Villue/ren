using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class TableLeaders : MonoBehaviour
{

    [SerializeField] private List<GameObject> panels;

    [SerializeField] private UserData userData;

    [SerializeField] private List<User> users;


    private void Start()
    {
        users = userData.Users;
        FillGrid();
    }

    private void FillGrid()
    {

        for (int b = 0; b < panels.Count; b++)
        {
            if (users.Count == 0)
                return;

            if (users.Count < b - 1)
                return;

            if (users.Count > 5)
                return;

            for (int i = 1; i < panels[b].transform.childCount; i++)
            {
                Debug.Log(i);

                if (users.Count < b - 1)
                    return;


                try
                {
                    if (i == 1)
                        panels[b].transform.GetChild(i).GetChild(0).GetComponent<TMPro.TMP_Text>().text = users[b].Name;

                    if (i == 2)
                        panels[b].transform.GetChild(i).GetChild(0).GetComponent<TMPro.TMP_Text>().text = users[b].Score.ToString();
                }
                catch (System.Exception)
                {
                    return;
                }
                
            }
        }
    }
}
