using StatsSystem.Enum;

namespace StatsSystem
{
    public interface IStatValueGiven
    {
        float GetStatValue(StatType statType);
    }
}