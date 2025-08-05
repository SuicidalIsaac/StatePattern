namespace ConsoleRPG.TrafficLights.States
{
    internal interface ITrafficLightState
    {
        void Action(TrafficLightActions.Actions action, TrafficLight trafficLight);
    }
}