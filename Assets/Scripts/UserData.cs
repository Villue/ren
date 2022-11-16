using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "user", menuName = "Data/UserData", order = 1)]
public class UserData : ScriptableObject
{
    public List<User> users;
}

public class User
{
    private string name;
    private int score;

    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    public int Score
    {
        set { score = value; }
        get { return score; }
    }

    public User(string name, int score)
    {
        this.name = name;
        this.score = score;
    }

    public override string ToString()
    {
        return Name;
    }

}