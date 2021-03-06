//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Osnowa.Osnowa.Core.ECS.Lifetime.DeathClockComponent deathClock { get { return (Osnowa.Osnowa.Core.ECS.Lifetime.DeathClockComponent)GetComponent(GameComponentsLookup.DeathClock); } }
    public bool hasDeathClock { get { return HasComponent(GameComponentsLookup.DeathClock); } }

    public void AddDeathClock(int newTurnsLeft) {
        var index = GameComponentsLookup.DeathClock;
        var component = (Osnowa.Osnowa.Core.ECS.Lifetime.DeathClockComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Core.ECS.Lifetime.DeathClockComponent));
        component.TurnsLeft = newTurnsLeft;
        AddComponent(index, component);
    }

    public void ReplaceDeathClock(int newTurnsLeft) {
        var index = GameComponentsLookup.DeathClock;
        var component = (Osnowa.Osnowa.Core.ECS.Lifetime.DeathClockComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Core.ECS.Lifetime.DeathClockComponent));
        component.TurnsLeft = newTurnsLeft;
        ReplaceComponent(index, component);
    }

    public void RemoveDeathClock() {
        RemoveComponent(GameComponentsLookup.DeathClock);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDeathClock;

    public static Entitas.IMatcher<GameEntity> DeathClock {
        get {
            if (_matcherDeathClock == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DeathClock);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDeathClock = matcher;
            }

            return _matcherDeathClock;
        }
    }
}
