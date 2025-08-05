namespace ConsoleRPG.TrafficLights.States.ConcreteState
{
    internal class EmergencyState : TrafficLightState
    {
        protected override bool IsActionSupported(TrafficLightActions.Actions action)
        {
            switch (action)
            {
                case TrafficLightActions.Actions.Fix: return true;
                default: return false;
            }
        }
        protected override void ExecuteAction(TrafficLightActions.Actions action, TrafficLight trafficLight)
        {
            trafficLight.ChangeState(new OffState());
        }
    }
}
