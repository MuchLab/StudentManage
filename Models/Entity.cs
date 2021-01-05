using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Homework06.Application.Models
{
    public abstract class Entity<TKey>
    {
        [Required]
        public TKey Id { get; set; }
    }
}
