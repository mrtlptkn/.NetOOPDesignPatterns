using DotNetDesignPatternsApp.Behavioral.State.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.State.Contracts;

public interface ITrafficLightState
{
    // TrafficLight bizim için bir context, bu sebeple state değişimi bu context üzerinden olmalıdır.
    void Next(TrafficLight trafficLight);

    // Yellow State -> Red ya da Green'e geçmek için işime yarayan bir özellik.
    string Color { get; }

    string Description { get; }

    // Geçiş kuralı her state tarafından belirlenir.
    bool CanTransitionTo(ITrafficLightState targetState);

    // default interface method (C# 8+)
    string CannotTransitionMessage(ITrafficLightState targetState)
        => "Cannot switch from " + Color + " to " + targetState.Color + " directly.";
}
