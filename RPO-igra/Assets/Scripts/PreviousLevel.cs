using UnityEngine;
using System.Collections;

public static class PreviousLevel  {

    private static string lastLevel;

    public static void setLastLevel(string level)
    {
        lastLevel = level;
    }

    public static string getLastLevel()
    {
        return lastLevel;
    }

    public static void changeToPreviousLvl()
    {
        Application.LoadLevel(lastLevel);
    }

}
