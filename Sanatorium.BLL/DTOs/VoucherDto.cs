﻿namespace Sanatorium.BLL.DTOs
{
    public class VoucherDto
    {
        public DateTime CreationDate { get; set; }

        public string Illness { get; set; }

        public int DayCount { get; set; }

        public PatientDto Patient { get; set; }
    }
}