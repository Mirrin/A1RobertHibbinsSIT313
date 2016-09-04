namespace HibbinzA2.Data
{
    public class ShopTrack
    {
        public ShopTrack()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public bool Done { get; set; }
    }
}

