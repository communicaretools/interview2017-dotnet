using System;

namespace PasReg.Model
{
    public class Registration
    {
        public Guid? Id { get; set; }
        public long PersonalId { get; set; }
        public string CodelistId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public Guid StudyId { get; set; }
        public string StudyGroup { get; set; }
    }
}