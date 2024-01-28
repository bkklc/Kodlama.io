﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

//public class Entity<T>
//{
//    public T Id { get; set; } 

//    public DateTime CreatedAt { get; set; }
//    public DateTime? UpdatedAt { get; set; }
//    public DateTime? DeletedAt { get; set; }
//}

public class Entity<TId> : IEntityTimestamps
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public Entity() { Id = default; }
    public Entity(TId id) { Id = id; }
}