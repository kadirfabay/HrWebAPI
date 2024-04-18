namespace HRWebAPI.Models
{
    public class UsersInformation
    {
        //public int Id { get; set; }
        //public int CvId { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public DateTime Birthday { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
        //public string? Gender { get; set; }
        //public string? City { get; set; }
        //public byte[]? Data { get; set; }
        public int Id { get; set; }
        //public int CvId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Section { get; set; }
        public string ContactPrefence { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public byte[]? Resume { get; set; }

        public string ActivityName { get; set; }

    }
}
