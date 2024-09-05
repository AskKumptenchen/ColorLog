using System.Collections.Generic;
using UnityEngine;

public class ColorLog
{
    private static readonly Dictionary<string, string> colorMap = new Dictionary<string, string>()
    {
        { "red", "#ff0000" },
        { "yellow", "#ffff00" },
        { "blue", "#0000ff" },
        { "green", "#00ff00" },
        { "purple", "#800080" },
        { "r", "#ff0000" },
        { "y", "#ffff00" },
        { "b", "#0000ff" },
        { "g", "#00ff00" },
        { "p", "#800080" }
    };

    // Simple Log
    public static void I(string message, string colorNameOrCode = null)
    {
        if (colorNameOrCode == null)
        {
            Debug.Log(message);
            return;
        }

        string colorCode = GetColorCode(colorNameOrCode);

        Debug.Log(string.Format("<color={0}>{1}</color>", colorCode, message));
    }

    // Error
    public static void E(string message, string colorNameOrCode = "red")
    {
        string colorCode = GetColorCode(colorNameOrCode);

        Debug.LogError(string.Format("<color={0}>{1}</color>", colorCode, message));
    }

    // Warning
    public static void W(string message, string colorNameOrCode = "yellow")
    {
        string colorCode = GetColorCode(colorNameOrCode);

        Debug.LogWarning(string.Format("<color={0}>{1}</color>", colorCode, message));
    }
    
    private static string GetColorCode(string colorNameOrCode)
    {
        if (colorMap.ContainsKey(colorNameOrCode.ToLower()))
        {
            return colorMap[colorNameOrCode.ToLower()];
        }
        else
        {
            return colorNameOrCode;
        }
    }
}
