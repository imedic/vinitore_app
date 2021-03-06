﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Vinitore.Domain.Command.DomainModels.WineManagment;

namespace Vinitore.Infrastructure.DbModel
{
    [Table("wine", Schema="public")]
    public class WineTb
    {
        [Column("wine_id")]
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("type")]
        public WineType Type { get; set; }

        [Column("year")]
        public int Year { get; set; }

        public List<BarrelTb> Barrels { get; set; }
    }
}
