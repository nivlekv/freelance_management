namespace FreelancersModel.Setting
{
    public class BaseSetting
    {
        public string EncryptionKey { get; set; } = string.Empty; 
        public string EncryptionVI { get; set; } = string.Empty;
        public string DbName { get; set; } = string.Empty;
        public string MySqlConnStr { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string PrivateKey { get; set; } = string.Empty;
        public string APIKey { get; set; } = string.Empty;
    }
}
