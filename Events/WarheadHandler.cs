namespace NukeLock.Events
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;

    internal sealed class WarheadHandler
    {
        public void onStarting(StartingEventArgs ev)
        {
            if (Round.ElapsedTime.TotalSeconds < Plugin.Instance.Config.LockTime)
            {
                ev.IsAllowed = false;
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast(7, $"<color=red>The warhead is disabled for {System.Math.Round(Plugin.Instance.Config.LockTime - Round.ElapsedTime.TotalSeconds)} more seconds!</color>");
            }
        }
//        public void onStopping(StoppingEventArgs ev) // lol I would use this for Auto Nuke, just use the base game feature
//        {
//            
//        }

        public void onLeverActivation(ChangingLeverStatusEventArgs ev)
        {
            if (Plugin.Instance.Config.PreventEnabling == true && Round.ElapsedTime.TotalSeconds < Plugin.Instance.Config.LockTime)
            {
                ev.IsAllowed = false;
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast(7, $"<color=red>The warhead is disabled for {System.Math.Round(Plugin.Instance.Config.LockTime - Round.ElapsedTime.TotalSeconds)} more seconds!</color>");
            }
        }
    }
}
