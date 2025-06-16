namespace SmartChef_API.Entities
{
    public class ParentEntity
    {
        public int Id { get; set; } //Primary Key - Identity
        public string CreatedBy { get; set; } = "System"; // nvarchar(max) not allowed to be null
        public string? UpdatedBy { get; set; } //nvarhcar(max) nullable
        public DateTime CreationDate { get; set; } = DateTime.Now; //DateTime not null
        public DateTime? UpdatedDate { get; set; }//DateTime nullable
        public bool IsActive { get; set; } = true;
    }
}
