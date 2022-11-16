using UnityEngine;

[CreateAssetMenu(fileName = "user", menuName = "Data/UserData", order = 1)]
public class UserData : ScriptableObject
{
    public string Username;

    public int Score;
}
