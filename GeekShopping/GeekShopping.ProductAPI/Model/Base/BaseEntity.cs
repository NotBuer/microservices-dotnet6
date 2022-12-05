namespace GeekShopping.ProductAPI.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }
    }
}
