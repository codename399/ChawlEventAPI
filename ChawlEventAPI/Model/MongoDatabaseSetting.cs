using ChawlEventAPI.Model.Dto;

namespace ChawlEvent.Model
{
    public class MongoDatabaseSetting
    {
        public string? LocalConnectionString { get; set; }
        public string? DevConnectionString { get; set; }
        public string? Environment { get; set; }
        public string? DatabaseName { get; set; }
        public string? ChawlEventDetailCollection { get; set; }
        public string? ContributionCollection { get; set; }
        public string? ContributorCollection { get; set; }
        public string? ExpenseCollection { get; set; }
        public string? ExpenseAssetCollection { get; set; }
        public string? UserCollection { get; set; }

        public static MongoDatabaseSettingDto ToDto(MongoDatabaseSetting databaseSetting)
        {
            return new MongoDatabaseSettingDto()
            {
                LocalConnectionString = databaseSetting.LocalConnectionString,
                DevConnectionString = databaseSetting.DevConnectionString,
                Environment = databaseSetting.Environment,
                DatabaseName = databaseSetting.DatabaseName
            };
        }
    }
}
