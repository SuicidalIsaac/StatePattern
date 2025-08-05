namespace StatePattern.TrafficLights.States
{
    internal abstract class TrafficLightState : ITrafficLightState
    {
        public void Action(TrafficLightActions.Actions action, TrafficLight trafficLight)
        {
            if (IsActionSupported(action))
            {
                ExecuteAction(action, trafficLight);
                Console.WriteLine($"Action {action}, New State {trafficLight.State}");
            } else
            {
                Console.WriteLine($"Action {action} not support for State {trafficLight.State}");
            }
        }

        protected abstract bool IsActionSupported(TrafficLightActions.Actions action);
        protected abstract void ExecuteAction(TrafficLightActions.Actions action, TrafficLight trafficLight);
    }
}
