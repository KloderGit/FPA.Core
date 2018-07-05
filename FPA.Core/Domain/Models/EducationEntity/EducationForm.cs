﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FPA.Core.Domain.Models.EducationEntity
{
    public class EducationForm
    {
        public string Guid { get; set; }

        /// <summary>
        /// Название Формы обучения Очно / Дистанционно
        /// </summary>
        public string Title { get; set; }
    }
}
