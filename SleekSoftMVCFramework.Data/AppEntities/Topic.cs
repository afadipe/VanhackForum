﻿using SleekSoftMVCFramework.Data.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleekSoftMVCFramework.Data.AppEntities
{
    public class Topic : BaseEntityWithAudit<int>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string TopicImage { get; set; }

        public int CategoryId { get; set; }

        public int? ViewCount { get; set; }
    }
}
