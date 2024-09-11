﻿namespace BookWebSyteBackEndMVC.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }    
        public DateTime CreatedAt { get; set; } 
        public DateTime? UpdtedAt { get; set; } 
    }
}
