﻿using UnityEngine;

namespace NsfwMiniJam.SO
{
    [CreateAssetMenu(menuName = "ScriptableObject/GameInfo", fileName = "GameInfo")]
    public class GameInfo : ScriptableObject
    {
        [Header("Game Info")]
        public int CumStrokeCountRequirement;

        [Header("Song info")]
        public MusicInfo[] Music;

        [Header("Note info")]
        public HitInfo[] HitInfo;
        public HitInfo MissInfo;
        public HitInfo WrongInfo;

        [Range(0f, 1f)]
        public float DecreaseOnHit, IncreaseOnMiss;

        [Header("Rank info")]
        public RankInfo[] RankInfo;

        [Header("Modifiers")]
        public float HiddenDistance;
        public float MineChancePercent;
        public float HypnotismChance;
        public int HypnotismHitCount;
        public int HypnotismNextNoteDelay;
    }

    [System.Serializable]
    public class MusicInfo
    {
        public RuntimeAnimatorController Controller;
        public TextAsset Intro;
        public string Name;
        public AudioClip Music;
        public float Bpm;
        public int NoteCount;

        [Header("Modifier")]
        public string ModifierName;
        [TextArea]
        public string ModifierDescription;

        [Header("Overrides")]
        public bool NoFailOverrides;
        public bool HypnotisedOverrides;
        public bool MinesOverrides;
        public bool KeyOverrides;
    }

    [System.Serializable]
    public class HitInfo
    {
        public string DisplayText;
        public float Distance;
        public Color Color;
        public bool DoesBreakCombo;

        public int Score;
    }

    [System.Serializable]
    public class RankInfo
    {
        public string Notation;
        public Color Color;
        [Range(0f, 1f)]
        public float ScoreRequirement;
    }
}