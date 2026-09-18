namespace DotNetDesignPatternsApp.Behavioral.State;

public interface ITrafficLightState
{
    // TrafficLight bizim için bir context, bu sebeple state değişimi bu context üzerinden olmalıdır.
    void Next(TrafficLight trafficLight);

    // Yellow State -> Red ya da Green'e geçmek için işime yarayan bir özellik.
    string Color { get; }

    string Description { get; }

    // Geçiş kuralı her state tarafından belirlenir.
    bool CanTransitionTo(ITrafficLightState targetState);

    // Java'daki default method karşılığı: default interface method (C# 8+)
    string CannotTransitionMessage(ITrafficLightState targetState)
        => "Cannot switch from " + Color + " to " + targetState.Color + " directly.";
}
