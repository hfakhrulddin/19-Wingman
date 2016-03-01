﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wingman.Core.Domain;

namespace Wingman.Core.Models
{
    public class WingmanUserModel
    { 
        public string UserName { get; set; }

        public int? NumberOfRatings { get; set; }
        public decimal? AverageRating { get; set; }
        public int? NumberOfAnswersPicked { get; set; }
        public int? NumberOfAnswersSubmitted { get; set; }
    }
}
