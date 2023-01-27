namespace Artista.Maui.Models
{
    public class BaseModel
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public UserModel UpdatedBy { get; set; }
    }
}
