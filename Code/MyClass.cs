namespace BioTest.Code
{
    public class MyClass
    {
        public async Task<string> GetExternalData(string url)
        {
            var client = new HttpClient();

            var response = await client.GetAsync(url);

            var data = await response.Content.ReadAsStringAsync();

            DatabaseClass.data = data;

            var database = new DatabaseClass();

            database.Save();

            return data;
        }
    }

    public class DatabaseClass
    {
        public static dynamic data { get; set; }
        public async Task Save()
        { }
    }
}