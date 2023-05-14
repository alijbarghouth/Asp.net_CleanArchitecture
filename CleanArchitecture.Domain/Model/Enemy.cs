﻿namespace CleanArchitecture.Domain.Model;

public class Enemy
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<EpisodeEnemy> EpisodeEnemies { get; set; }
}