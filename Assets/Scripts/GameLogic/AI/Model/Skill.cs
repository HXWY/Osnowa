﻿namespace GameLogic.AI.Model
{
	using System.Collections.Generic;
	using ActivityCreation;
	using SkillEvaluation;
	using UnityEngine;

	[CreateAssetMenu(fileName = "Skill", menuName = "Osnowa/AI/Skills/Skill", order = 0)]
	public class Skill : ScriptableObject
	{
		public string Name;

		public SkillEvaluator Evaluator;

		public ActivityCreator ActivityCreator;

		/// <summary>
		/// Stimuli that can trigger execution of this skill by the actor.
		/// </summary>
		public List<StimulusType> StimuliToBreakIn;

		public List<Condition> Conditions;
	}
}