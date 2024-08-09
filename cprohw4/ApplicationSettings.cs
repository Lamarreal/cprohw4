
namespace cprohw4
{
    public class ApplicationSettings
    {
        private DatabaseSettings _databaseSettings;
        public DatabaseSettings dataSettings => _databaseSettings;

        public string ApplicationName = string.Empty;
        public string ApplicationVersion = string.Empty;
        public ApplicationSettings() {
            _databaseSettings = new DatabaseSettings();
            ApplicationVersion = "1.0";
            ApplicationName = "My app";
        }

        public class DatabaseSettings
        {
            public SuccesStatus connStatus;
            public int lastConnectiontime;
            public DatabaseSettings()
            {

                connStatus = SuccesStatus.Success;
            }
        }
    }
    public enum SuccesStatus
    {
        Denied = 0,
        Success = 1,
    }
   
}
