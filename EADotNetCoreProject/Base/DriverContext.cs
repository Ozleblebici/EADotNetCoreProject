namespace EAAutoFramework.Base
{
    public class DriverContext
    {

        public readonly ParallelConfig _parellelConfig;

        public DriverContext(ParallelConfig parellelConfig)
        {
            _parellelConfig = parellelConfig;
        }


        public void GoToUrl(string url)
        {
            _parellelConfig.Driver.Url = url;
        }


        public static Browser Browser { get; set; }

    }
}
