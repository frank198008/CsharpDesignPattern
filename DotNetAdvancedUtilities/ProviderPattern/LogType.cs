namespace DotNetAdvancedUtilities.ProviderPattern
{
    public class LogType
    {
        /// <summary>
        /// 程序异常
        /// </summary>
        public const string Exception = "Error";

        /// <summary>
        /// 应用程序跟踪
        /// </summary>
        public const string ApplicationTrack = "Track";

        private string _type;

        public LogType(string type)
        {
            this._type = type;
        }
    }
}