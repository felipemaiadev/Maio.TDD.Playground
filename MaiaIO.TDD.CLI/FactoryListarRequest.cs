﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MaiaIO.TDD.CLI
{
    public class FactoryListarRequest
    {

        [Required]
        [DefaultValue(0)]
        public long? Id { get; set; }

        [Required]
        [DefaultValue("no")]
        public string? Name { get; set; }
        [Required]
        [DefaultValue("no")]
        public string? Country { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool? IsActive { get; set; }




    }
}