namespace Kate_Lab1.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime DeactivateTime { get; set; }
        public DateTime LastChange { get; set; }
        public int LastChangeStaffId { get; set; }
    }
}
