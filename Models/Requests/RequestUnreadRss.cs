﻿namespace OUTLOUD_Test_proj.Models.Requests
{
    public class RequestUnreadRss : BaseRequest
    {
        public DateTime Date { get; set; }
        public int AddDays { get; set; }
    }
}
