﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWayRazor.Models
{
    [Table("Status")]
    public class Status : IBaseEntity
    {
        [Key]
        public int StatusID { get; set; }
        [Required, MaxLength(25), Display(Name = "Status:")]
        public string Statuses { get; set; }

        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }

        public ICollection<Colaborador> Colaboradores { get; set; }
    }
}