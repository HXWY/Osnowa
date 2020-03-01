//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Osnowa.Osnowa.Example.ECS.AI.StimuliComponent stimuli { get { return (Osnowa.Osnowa.Example.ECS.AI.StimuliComponent)GetComponent(GameComponentsLookup.Stimuli); } }
    public bool hasStimuli { get { return HasComponent(GameComponentsLookup.Stimuli); } }

    public void AddStimuli(System.Collections.Generic.List<GameLogic.AI.Model.Stimulus> newStimuli) {
        var index = GameComponentsLookup.Stimuli;
        var component = (Osnowa.Osnowa.Example.ECS.AI.StimuliComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Example.ECS.AI.StimuliComponent));
        component.Stimuli = newStimuli;
        AddComponent(index, component);
    }

    public void ReplaceStimuli(System.Collections.Generic.List<GameLogic.AI.Model.Stimulus> newStimuli) {
        var index = GameComponentsLookup.Stimuli;
        var component = (Osnowa.Osnowa.Example.ECS.AI.StimuliComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Example.ECS.AI.StimuliComponent));
        component.Stimuli = newStimuli;
        ReplaceComponent(index, component);
    }

    public void RemoveStimuli() {
        RemoveComponent(GameComponentsLookup.Stimuli);
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

    static Entitas.IMatcher<GameEntity> _matcherStimuli;

    public static Entitas.IMatcher<GameEntity> Stimuli {
        get {
            if (_matcherStimuli == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Stimuli);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStimuli = matcher;
            }

            return _matcherStimuli;
        }
    }
}
