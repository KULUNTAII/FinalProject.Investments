﻿using System.ComponentModel.DataAnnotations;
using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Enums;

namespace FinalProject.Domain.Entities
{
    public class Participant : Entity
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required List<QualificationType> QualificationType { get; set; }
        public List<string> WorkExperience{ get; set; }
        public List<string> Awards { get; set; }
        public Skills Skills { get; set; }
        public List<Project> Projects { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
        public int PhoneNumber { get; set; }
        public List<string> Links { get; set; }
        public string Country { get; set; }
        public List<Participant> Followers { get; set; }
    }
}