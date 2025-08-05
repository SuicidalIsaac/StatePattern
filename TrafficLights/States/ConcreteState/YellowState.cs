namespace ConsoleRPG.TrafficLights.States.ConcreteState
{
    internal class YellowState : TrafficLightState
    {
        protected override bool IsActionSupported(TrafficLightActions.Actions action)
        {
            switch (action)
            {
                case TrafficLightActions.Actions.Switch: return true;
                case TrafficLightActions.Actions.Emergency: return true;
                default: return false;
            }
        }
        protected override void ExecuteAction(TrafficLightActions.Actions action, TrafficLight trafficLight)
        {
            switch (action)
            {
                case TrafficLightActions.Actions.Switch: trafficLight.ChangeState(new RedState()); break;
                case TrafficLightActions.Actions.Emergency: trafficLight.ChangeState(new EmergencyState()); break;
            }
        }
    }
}
