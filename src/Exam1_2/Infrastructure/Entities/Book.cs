﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Book : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PublicationName { get; set; }
    }
}
