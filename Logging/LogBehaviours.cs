using Il2CppAssets.Scripts.Models;
using MelonLoader;
using System.Collections.Generic;

namespace CeramicMonkey.Logging;

public class LogBehaviours
{
    public static void Log<T>(IEnumerable<T> behaviours, string modelName) where T : Model
    {
        MelonLogger.Msg("Logging behaviours of " + modelName + " {");

        foreach (var behavior in behaviours)
        {
            MelonLogger.Msg($"Behavior: {behavior.name} ({behavior.GetType()})");
        }

        MelonLogger.Msg("}");
    }
}
